using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZianLauncher2
{
    public class mc_1_16_2: VersionFile
    {
        public override string ToArguments(Global.loadMode mode, string _GameRootPath, string ID, string RAM)
        {
            string str = "";
            //str += "-Dfml.ignoreInvalidMinecraftCertificates=true";
            //str += " -Dfml.ignorePatchDiscrepancies=true";
            str += " -Xmx" + RAM + "M";
            str += " -Djava.library.path=" + _GameRootPath + @"\versions\1.16.2\1.16.2-natives";
            if (mode == Global.loadMode.Offline)
            {
                //str += " -Djava.library.path=" + _GameRootPath + @"\versions\1.16.2\1.16.2-natives";
                str += OfflineArguments(_GameRootPath);
                str += " net.minecraft.client.main.Main";
                str += " --version 1.16.2";
            }
            else if (mode == Global.loadMode.OfflineForge)
            {
                //str += " -Djava.library.path=" + _GameRootPath + @"\versions\1.16.2-forge-33.0.5\1.16.2-forge-33.0.5-natives";
                str += ForgeArguments(_GameRootPath);
                str += " cpw.mods.modlauncher.Launcher";
                str += " --launchTarget fmlclient";
                str += " --fml.forgeVersion 33.0.5";
                str += " --fml.mcVersion 1.16.2";
                str += " --fml.forgeGroup net.minecraftforge";
                str += " --fml.mcpVersion 20200812.004259";
                str += " --version 1.16.2-forge-33.0.5";
            }
            str += " --username " + ID;
            str += " --gameDir " + _GameRootPath;
            str += " --assetsDir " + _GameRootPath + @"\assets";
            str += " --assetIndex 1.16";
            str += " --uuid ${auth_uuid}";
            str += " --accessToken ${auth_access_token}";
            str += " --userType Legacy";
            str += " --versionType release";
            return str;
        }
        public string[] Offline_cpclass =
     {
@"\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;",
@"\libraries\com\mojang\javabridge\1.0.22\javabridge-1.0.22.jar;",
@"\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;",
@"\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;",
@"\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;",
@"\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;",
@"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;",
@"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;",
@"\libraries\com\mojang\brigadier\1.0.17\brigadier-1.0.17.jar;",
@"\libraries\com\mojang\authlib\1.6.25\authlib-1.6.25.jar;",
@"\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;",
@"\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;",
@"\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;",
@"\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;",
@"\libraries\com\mojang\datafixerupper\4.0.26\datafixerupper-4.0.26.jar;",
@"\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;",
@"\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;",
@"\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;",
@"\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;",
@"\libraries\org\lwjgl\lwjgl-jemalloc\3.2.2\lwjgl-jemalloc-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl\3.2.2\lwjgl-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-openal\3.2.2\lwjgl-openal-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-glfw\3.2.2\lwjgl-glfw-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-stb\3.2.2\lwjgl-stb-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-tinyfd\3.2.2\lwjgl-tinyfd-3.2.2.jar;",
@"\libraries\com\mojang\text2speech\1.11.3\text2speech-1.11.3.jar;",
@"\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;",
@"\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;",
@"\libraries\org\lwjgl\lwjgl-opengl\3.2.2\lwjgl-opengl-3.2.2.jar;",
@"\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;",
@"\libraries\com\google\guava\guava\21.0\guava-21.0.jar;",
@"\libraries\com\ibm\icu\icu4j\66.1\icu4j-66.1.jar;",
@"\libraries\it\unimi\dsi\fastutil\8.2.1\fastutil-8.2.1.jar;",
@"\versions\1.16.2\1.16.2.jar"
        };

        public string[] Forge_cpclass =
        {
@"\libraries\cpw\mods\grossjava9hacks\1.3.0\grossjava9hacks-1.3.0.jar;",
@"\libraries\net\minecraftforge\forge\1.16.2-33.0.5\forge-1.16.2-33.0.5.jar;",
@"\libraries\org\ow2\asm\asm-tree\7.2\asm-tree-7.2.jar;",
@"\libraries\net\minecraftforge\eventbus\3.0.3-service\eventbus-3.0.3-service.jar;",
@"\libraries\org\ow2\asm\asm-util\7.2\asm-util-7.2.jar;",
@"\libraries\org\ow2\asm\asm-commons\7.2\asm-commons-7.2.jar;",
@"\libraries\org\ow2\asm\asm-analysis\7.2\asm-analysis-7.2.jar;",
@"\libraries\cpw\mods\modlauncher\6.1.1\modlauncher-6.1.1.jar;",
@"\libraries\org\ow2\asm\asm\7.2\asm-7.2.jar;",
@"\libraries\net\minecraftforge\forgespi\3.1.1\forgespi-3.1.1.jar;",
@"\libraries\net\minecraftforge\coremods\3.0.0\coremods-3.0.0.jar;",
@"\libraries\net\minecraftforge\unsafe\0.2.0\unsafe-0.2.0.jar;",
@"\libraries\com\electronwill\night-config\toml\3.6.2\toml-3.6.2.jar;",
@"\libraries\net\minecraftforge\accesstransformers\2.2.0-shadowed\accesstransformers-2.2.0-shadowed.jar;",
@"\libraries\net\jodah\typetools\0.8.1\typetools-0.8.1.jar;",
@"\libraries\org\apache\maven\maven-artifact\3.6.0\maven-artifact-3.6.0.jar;",
@"\libraries\net\minecrell\terminalconsoleappender\1.2.0\terminalconsoleappender-1.2.0.jar;",
@"\libraries\com\electronwill\night-config\core\3.6.2\core-3.6.2.jar;",
@"\libraries\com\mojang\patchy\1.1\patchy-1.1.jar;",
@"\libraries\net\sf\jopt-simple\jopt-simple\5.0.4\jopt-simple-5.0.4.jar;",
@"\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;",
@"\libraries\org\apache\logging\log4j\log4j-api\2.11.2\log4j-api-2.11.2.jar;",
@"\libraries\com\mojang\javabridge\1.0.22\javabridge-1.0.22.jar;",
@"\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;",
@"\libraries\org\jline\jline\3.12.1\jline-3.12.1.jar;",
@"\libraries\org\spongepowered\mixin\0.8\mixin-0.8.jar;",
@"\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;",
@"\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;",
@"\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;",
@"\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;",
@"\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;",
@"\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;",
@"\libraries\com\mojang\brigadier\1.0.17\brigadier-1.0.17.jar;",
@"\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;",
@"\libraries\org\apache\logging\log4j\log4j-core\2.11.2\log4j-core-2.11.2.jar;",
@"\libraries\com\mojang\authlib\1.6.25\authlib-1.6.25.jar;",
@"\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;",
@"\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;",
@"\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;",
@"\libraries\com\mojang\datafixerupper\4.0.26\datafixerupper-4.0.26.jar;",
@"\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;",
@"\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;",
@"\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;",
@"\libraries\org\lwjgl\lwjgl-jemalloc\3.2.2\lwjgl-jemalloc-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-openal\3.2.2\lwjgl-openal-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl\3.2.2\lwjgl-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-glfw\3.2.2\lwjgl-glfw-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-tinyfd\3.2.2\lwjgl-tinyfd-3.2.2.jar;",
@"\libraries\org\lwjgl\lwjgl-stb\3.2.2\lwjgl-stb-3.2.2.jar;",
@"\libraries\com\google\guava\guava\21.0\guava-21.0.jar;",
@"\libraries\com\mojang\text2speech\1.11.3\text2speech-1.11.3.jar;",
@"\libraries\org\lwjgl\lwjgl-opengl\3.2.2\lwjgl-opengl-3.2.2.jar;",
@"\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;",
@"\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;",
@"\libraries\com\ibm\icu\icu4j\66.1\icu4j-66.1.jar;",
@"\libraries\it\unimi\dsi\fastutil\8.2.1\fastutil-8.2.1.jar;",
@"\versions\1.16.2\1.16.2-forge-33.0.5.jar"
};
        string OfflineArguments(string _GameRootPath)
        {
            string str = " -cp ";
            for (int i = 0; i < Offline_cpclass.Length; i++)
            {
                str += _GameRootPath + Offline_cpclass[i];
            }
            return str;
        }
        string ForgeArguments(string _GameRootPath)
        {
            string str = " -cp ";
            for (int i = 0; i < Forge_cpclass.Length; i++)
            {
                str += _GameRootPath + Forge_cpclass[i];
            }
            return str;
        }
    }
}
