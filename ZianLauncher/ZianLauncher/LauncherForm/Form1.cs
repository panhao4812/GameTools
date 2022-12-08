
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LitJson;
namespace ZianLauncher.LauncherForm
{
    public partial class LauncherForm : Form
    {
        public enum loadMode
        {
            Online,
            Offline,
            OnlineForge,
            OfflineForge
        }
        public static bool DebugMode = false;
        List<string> _classpass = new List<string>();//-cp
        string _mainclass = "";
        string FJpath = "";
        string OJpath = "";
        string _GameRootPath = System.Environment.CurrentDirectory + @"\.minecraft";
        string _launcherdatapath = System.Environment.CurrentDirectory + @"\launcherdata.txt";
        LauncherWriter lw = new LauncherWriter();
        public Global P = new Global(DebugMode);//debug
        JsonFile FJ = new JsonFile();//json文件
        JsonFile OJ = new JsonFile();//json文件
        private void ReadJson()//初始化json文件类
        {
            List<string> output = new List<string>();
            Global._SearchFiles(_GameRootPath + @"\versions", ".json", ref output);
            if (output.Count == 1)
            {
                OJpath = output[0];
                OJ = JsonMapper.ToObject<JsonFile>(File.OpenText(OJpath));
                buttonF.Text = "Forge" + Path.GetFileNameWithoutExtension(OJpath);
                buttonF.Enabled = false;
                buttonO.Text = Path.GetFileNameWithoutExtension(OJpath);
                buttonO.Enabled = true;
            }
            if (output.Count == 2)
            {
                if (Path.GetFileNameWithoutExtension(output[0]).Contains("Forge") || Path.GetFileNameWithoutExtension(output[0]).Contains("forge"))
                { FJpath = output[0]; OJpath = output[1]; }
                else { FJpath = output[1]; OJpath = output[0]; }
                FJ = JsonMapper.ToObject<JsonFile>(File.OpenText(FJpath));
                OJ = JsonMapper.ToObject<JsonFile>(File.OpenText(OJpath));
                buttonF.Text = "Forge" + Path.GetFileNameWithoutExtension(OJpath);
                buttonO.Text = Path.GetFileNameWithoutExtension(OJpath);
                buttonF.Enabled = true;
                buttonO.Enabled = true;
            }
            output.Clear();
            Global._SearchFiles(_GameRootPath + @"\versions", ".jar", ref output);
            _mainclass = output[0];
        }
        public string ToArguments(loadMode mode)
        {
            StringBuilder builder = new StringBuilder();
            if (Path.GetFileNameWithoutExtension(this.textBoxJava.Text) == "javaw")
            {
                builder.Append(" -Xincgc");
                builder.Append(" -XX:+AggressiveOpts");//使用java的新功能优化，可能不稳定
            }
            else
            {
                //builder.Append(" -Dminecraft.client.jar =.minecraft\\versions\\1.13\\1.13.jar");
                builder.Append(" -XX:+UnlockExperimentalVMOptions");
                builder.Append(" -XX:+UseG1GC");
                builder.Append(" -XX:G1NewSizePercent=20");
                builder.Append(" -XX:G1ReservePercent=20");
                builder.Append(" -XX:MaxGCPauseMillis=50");
                builder.Append(" -XX:G1HeapRegionSize=16M");
                builder.Append(" -XX:-UseAdaptiveSizePolicy");
                builder.Append(" -XX:-OmitStackTraceInFastThrow");
                builder.Append(" -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump");
            }
            if (Environment.Is64BitOperatingSystem && Convert.ToInt32(this.lw._Xmx) < 2048)
            {
                builder.Append(" -XX:+UseCompressedOops");//指针压缩
            }         
            builder.Append(" -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true");
            builder.Append(" -Xmx" + this.lw._Xmx + "M");
            string native = this._GameRootPath + @"\$natives";
            if (!Directory.Exists(native))
            {
                string versionID = "";
                if (FJpath!="")
                {
                     versionID = Path.GetFileNameWithoutExtension(FJpath);
                }
                else
                {
                     versionID = Path.GetFileNameWithoutExtension(OJpath);
                }
                native = _GameRootPath + @"\versions\" + versionID + @"\" + versionID + "-natives";
            }
            builder.Append(" -Djava.library.path=" + (char)34 + native + (char)34);
            //这个Djava.library.path位置可能也在version\1.x.x\里面,全是dll文件，复制一个出来即可
            builder.Append(" -cp " + (char)34);
            if (mode == loadMode.OfflineForge || mode == loadMode.OnlineForge) builder.Append(FJ.CPArguments(_GameRootPath));
            builder.Append(OJ.CPArguments(_GameRootPath));
            builder.Append(this._mainclass);
            builder.Append((char)34 + " ");
            if (mode == loadMode.OfflineForge) builder.Append(FJ.ToArgumentsOffLine(this.lw._username, this.lw._uuid, this.lw._AccessToken, _GameRootPath));
            if (mode == loadMode.OnlineForge) builder.Append(FJ.ToArgumentsOnLine(this.lw._username, this.lw._uuid, this.lw._AccessToken, this.lw._password, _GameRootPath));
            if (mode == loadMode.Offline) builder.Append(OJ.ToArgumentsOffLine(this.lw._username, this.lw._uuid, this.lw._AccessToken, _GameRootPath));
            if (mode == loadMode.Online) builder.Append(OJ.ToArgumentsOnLine(this.lw._username, this.lw._uuid, this.lw._AccessToken, this.lw._password, _GameRootPath));
            return builder.ToString();
        }
        public LauncherForm()
        {
            InitializeComponent();
            lw.ReadFromFile(_launcherdatapath);
            this.textBoxID.Text = this.lw._username;
            this.textBoxPassword.Text = this.lw._password;
            this.textBoxRAM.Text = this.lw._Xmx;
            this.textBoxJava.Text = this.lw._JavaPath;
            ReadJson();
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            this.lw._username = this.textBoxID.Text;
            this.lw._password = this.textBoxPassword.Text;
            this.lw._Xmx = this.textBoxRAM.Text;
            this.lw._JavaPath = this.textBoxJava.Text;
            lw.WriteToFile(_launcherdatapath);
            string arguments = "";
            if (this.lw._password == "") arguments = ToArguments(loadMode.OfflineForge);
            else arguments = ToArguments(loadMode.OnlineForge);
            if (DebugMode)
            {
                StreamWriter sw = new StreamWriter(System.Environment.CurrentDirectory + @"\ZianLauncherArguments.txt", false);
                sw.Write(arguments);
                sw.Close();
            }
            ProcessStartInfo startInfo = new ProcessStartInfo(this.lw._JavaPath)
            {
                Arguments = arguments,
                UseShellExecute = false,
                WorkingDirectory = this._GameRootPath,//log文件夹
                RedirectStandardError = false,
                RedirectStandardOutput = false
            };
            Process javaprocess = Process.Start(startInfo);
            javaprocess.Close();
            if (!DebugMode) this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = System.Environment.CurrentDirectory;
            ofd.RestoreDirectory = true;
            ofd.Filter = "(*.exe)|*.exe";
            ofd.Title = "Please select jawaw.exe or java.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.textBoxJava.Text = ofd.FileName;
            }
        }
        private void buttonO_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.textBoxJava.Text))
            {
                this.textBoxJava.Text = "Select Java path!";
                return;
            }
            this.lw._username = this.textBoxID.Text;
            this.lw._password = this.textBoxPassword.Text;
            this.lw._Xmx = this.textBoxRAM.Text;
            this.lw._JavaPath = this.textBoxJava.Text;
            lw.WriteToFile(_launcherdatapath);
            string arguments = "";
            if (this.lw._password == "") arguments = ToArguments(loadMode.Offline);
            else arguments = ToArguments(loadMode.Online);
            if (DebugMode)
            {
                StreamWriter sw = new StreamWriter(System.Environment.CurrentDirectory + @"\ZianLauncherArguments.txt", false);
                sw.Write(arguments);
                sw.Close();
            }
            ProcessStartInfo startInfo = new ProcessStartInfo(this.lw._JavaPath)
            {
                Arguments = arguments,
                UseShellExecute = false,
                WorkingDirectory = this._GameRootPath,//log文件夹
                RedirectStandardError = false,
                RedirectStandardOutput = false
            };
            Process javaprocess = Process.Start(startInfo);
            javaprocess.Close();
            if (!DebugMode) this.Close();
        }
    }
}
