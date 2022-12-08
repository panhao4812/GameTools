
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace ZianLauncher2
{
    public partial class LauncherForm2 : Form
    {        
        public static bool DebugMode = false;
        string _GameRootPath = System.Environment.CurrentDirectory + @"\.minecraft";
        public Global P = new Global(DebugMode);//debug
        public string ToArguments(Global.loadMode mode)
        {
            VersionFile mc;
            if (VersionBox.Text == "1.16.1") mc = new mc_1_16_1();
            else if (VersionBox.Text == "1.16.2") mc = new mc_1_16_2();
            else return "";
            return mc.ToArguments(mode, _GameRootPath, textBoxID.Text, RAMBox.Text);
        }
        public LauncherForm2()
        {
            InitializeComponent();
            RAMBox.SelectedIndex = 1;
            VersionBox.SelectedIndex = 1;
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.textBoxJava.Text))
            {
                this.textBoxJava.Text = "Select Java path!";
                return;
            }
            string arguments = ToArguments(Global.loadMode.OfflineForge);
            if (arguments != "") StartProcess(arguments);
        }
        private void buttonO_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.textBoxJava.Text))
            {
                this.textBoxJava.Text = "Select Java path!";
                return;
            }
            string arguments = ToArguments(Global.loadMode.Offline);
            if(arguments!="")StartProcess(arguments);
        }
        public void StartProcess(string arguments)
        {
            if (DebugMode)
            {
                StreamWriter sw = new StreamWriter(System.Environment.CurrentDirectory + @"\ZianLauncherArguments.txt", false);
                sw.Write(arguments);
                sw.Close();
            }
            ProcessStartInfo startInfo = new ProcessStartInfo(this.textBoxJava.Text)
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
    }
}
