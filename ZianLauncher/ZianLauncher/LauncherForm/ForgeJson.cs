using System;
using System.Collections.Generic;
using LitJson;
using System.Text;
using System.IO;
using System.Net;

namespace ZianLauncher.LauncherForm
{
    public class AuthResponse
    {
        public AuthResponse() { }
        public string cause { get; set; }
        public string error { get; set; }
        public string errorMessage { get; set; }
        public string accessToken { get; set; }
        public List<GameProfile> availableProfiles { get; set; }
        public string clientToken { get; set; }
        public GameProfile selectedProfile { get; set; }
        public User user { get; set; }
        // Nested Types
        public class Properties
        {
            public string name { get; set; }
            public string value { get; set; }
        }
        public class User
        {
            public string id { get; set; }
            public List<AuthResponse.Properties> properties { get; set; }
        }
        public class GameProfile
        {
            public string id { get; set; }
            public string name { get; set; }
        }
    }
    public class JsonFile
    {
        public string CPArguments(string _GameRootPath)
        {
            StringBuilder builder = new StringBuilder();
            List<string> cp = new List<string>();
            for (int i = 0; i < this.libraries.Count; i++)
            {
                cp.AddRange(libraries[i].ToPath(_GameRootPath));
            }
            foreach (string str2 in cp)
            {
                if (str2 != null && str2.Length > 0) builder.Append(str2 + ';');
            }
            return builder.ToString();
        }
        public string ToArgumentsOnLine(string _username, string _uuid, string _AccessToken, string _password, string _GameRootPath)
        {
            try
            {
                JsonData data = new JsonData();
                data["agent"] = new JsonData();
                data["agent"]["name"] = "Minecraft";
                data["agent"]["version"] = "1";
                data["username"] = _username;
                data["password"] = _password;
                data["clientToken"] = "";
                WebClient wc = new WebClient();
                string output = wc.UploadString(new Uri("https://authserver.mojang.com/authenticate"), data.ToJson());
                AuthResponse response = JsonMapper.ToObject<AuthResponse>(output);
                /////////////////////////////////////////////////////////////////////////
                if (this.assets == "")
                {
                    List<string> str123 = new List<string>();
                    Global._SearchFiles(_GameRootPath + @"\assets\indexes", ".json", ref str123);
                    if (str123.Count == 0)
                    {
                        string[] str3 = id.Split('.'); assets = str3[0] + "." + str3[1];
                    }
                    else
                    {
                        assets = Path.GetFileNameWithoutExtension(str123[0]);
                    }
                }
                string UUID = response.user.id;
                string AccessToken = response.accessToken;
                StringBuilder builder = new StringBuilder();
                builder.Append(mainClass + " ");
                string Arguments = minecraftArguments;
                Arguments = Arguments.Replace("--username ${auth_player_name}", "--username " + _username);
                Arguments = Arguments.Replace("--session ${auth_session}", "--session " + AccessToken);
                Arguments = Arguments.Replace("--version ${version_name}", "--version " + id);
                Arguments = Arguments.Replace("--gameDir ${game_directory}", "--gameDir " + (char)34 + _GameRootPath + (char)34);
                Arguments = Arguments.Replace("--assetsDir ${assets_root}", "--assetsDir " + (char)34 + _GameRootPath + @"\assets" + (char)34);
                Arguments = Arguments.Replace("--assetsDir ${game_assets}", "--assetsDir " + (char)34 + _GameRootPath + @"\assets" + (char)34);
                Arguments = Arguments.Replace("--assetIndex ${assets_index_name}", "--assetIndex " + assets);
                Arguments = Arguments.Replace("--uuid ${auth_uuid}", "--uuid " + UUID);
                Arguments = Arguments.Replace("--accessToken ${auth_access_token}", "--accessToken " + AccessToken);
                Arguments = Arguments.Replace("--userProperties ${user_properties}", "--userProperties {}");
                Arguments = Arguments.Replace("--userType ${user_type}", "--userType Mojang");
                // Arguments = Arguments.Replace("--versionType ${version_type}", "--versionType release");
                builder.Append(Arguments);
                return builder.ToString();
            }
            catch
            {
                return ToArgumentsOffLine(_username, _uuid, _AccessToken, _GameRootPath);
            }
        }
        public string ToArgumentsOffLine(string _username, string _uuid, string _AccessToken, string _GameRootPath)
        {
            if (this.assets == "")
            {
                List<string> str123 = new List<string>();
                Global._SearchFiles(_GameRootPath + @"\assets\indexes", ".json", ref str123);
                if (str123.Count == 0)
                {
                    string[] str3 = id.Split('.'); assets = str3[0] + "." + str3[1];
                }
                else
                {
                    assets = Path.GetFileNameWithoutExtension(str123[0]);
                }
            }
            string UUID = _uuid;
            string AccessToken = _AccessToken;
            StringBuilder builder = new StringBuilder();
            builder.Append(mainClass + " ");
            string Arguments = minecraftArguments;
            Arguments = Arguments.Replace("--username ${auth_player_name}", "--username " + _username);
            Arguments = Arguments.Replace("--session ${auth_session}", "--session " + AccessToken);
            Arguments = Arguments.Replace("--version ${version_name}", "--version " + id);
            Arguments = Arguments.Replace("--gameDir ${game_directory}", "--gameDir " + (char)34 + _GameRootPath + (char)34);
            Arguments = Arguments.Replace("--assetsDir ${assets_root}", "--assetsDir " + (char)34 + _GameRootPath + @"\assets" + (char)34);
            Arguments = Arguments.Replace("--assetsDir ${game_assets}", "--assetsDir " + (char)34 + _GameRootPath + @"\assets" + (char)34);
            Arguments = Arguments.Replace("--assetIndex ${assets_index_name}", "--assetIndex " + assets);
            Arguments = Arguments.Replace("--uuid ${auth_uuid}", "--uuid " + UUID);
            Arguments = Arguments.Replace("--accessToken ${auth_access_token}", "--accessToken " + AccessToken);
            Arguments = Arguments.Replace("--userProperties ${user_properties}", "--userProperties {}");
            Arguments = Arguments.Replace("--userType ${user_type}", "--userType Mojang");
            Arguments = Arguments.Replace("--versionType ${version_type}", "--versionType release");
            // Arguments = Arguments.Replace("--versionType ${version_type}", "--versionType release");
            builder.Append(Arguments);
            return builder.ToString();
        }
        public JsonFile() { id = ""; minecraftArguments = ""; mainClass = ""; assets = ""; }
        public string id { get; set; }
        public string assets { get; set; }
        public string minecraftArguments { get; set; }
        public string mainClass { get; set; }
        public List<CPlibrary> libraries { get; set; }
        public class CPlibrary
        {
            public CPlibrary() { }
            public string name { get; set; }
            public List<string> ToPath(string _GameRootPath)
            {
                string[] str = name.Split(':');
                if (str.Length <= 0)
                {// Console.Print("error CPlibrary.ToPath()");
                    return null;
                }
                string[] str2 = str[0].Split('.');
                string path = _GameRootPath + @"\libraries\";
                for (int i = 0; i < str2.Length; i++) { path += str2[i] + @"\"; }
                if (str.Length > 1)
                {
                    for (int i = 1; i < str.Length; i++)
                    {
                        path += str[i];
                        if (i != str.Length - 1) path += @"\";
                    }
                }
                List<string> output = new List<string>();
                Global._SearchFiles(path, ".jar", ref output);
                return output;
            }
        }
    }
}
