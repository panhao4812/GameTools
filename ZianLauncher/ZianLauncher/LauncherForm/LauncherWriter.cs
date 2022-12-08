using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;
using System.IO;

namespace ZianLauncher.LauncherForm
{
    public class LauncherWriter
    {
        public string _username { get; set; }
        public string _uuid { get; set; }
        public string _AccessToken { get; set; }
        public string _password { get; set; }
        public string _Xmx { get; set; }
        public string _JavaPath { get; set; }


        public LauncherWriter()
        {
            DefaultData();
        }
        public void CreateFrom(LauncherWriter _copy)
        {
            DefaultData();
            if (_copy._username != null && _copy._username != "") _username = _copy._username;
            if (_copy._uuid != null && _copy._uuid != "") _uuid = _copy._uuid;
            if (_copy._AccessToken != null && _copy._AccessToken != "") _AccessToken = _copy._AccessToken;
            if (_copy._password != null && _copy._password != "") _password = _copy._password;
            if (_copy._Xmx != null && _copy._Xmx != "") _Xmx = _copy._Xmx;
            if (_copy._JavaPath != null && _copy._JavaPath != "") _JavaPath = _copy._JavaPath;
        }
        public void DefaultData()
        {
            _username = "Brats";
            _uuid = Guid.NewGuid().ToString("N");
            _AccessToken = Guid.NewGuid().ToString("N");
            _password = "";
            _Xmx = "2048";
            _JavaPath = "C:\\Program Files\\Java\\jre1.8.0_161\\bin\\javaw.exe";
        }
        public void ReadFromFile(string path)
        {

            StreamReader sr;
            if (File.Exists(path)) sr = new StreamReader(path); else return;
            try
            {
                
                this.CreateFrom(JsonMapper.ToObject<LauncherWriter>(sr.ReadToEnd()));
                sr.Close();
            }
            catch
            {
                DefaultData();
                sr.Close();
            }

        }
        public void WriteToFile(string path)
        {
            
                StreamWriter sw = new StreamWriter(path, false);
            try
            {
                sw.Write(JsonMapper.ToJson(this));
                sw.Close();
            }
            catch
            {
                sw.Close();
            }
        }

    }
}
