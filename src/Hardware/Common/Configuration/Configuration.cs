using System.Diagnostics;
using System.IO;
using nanoFramework.Json.Configuration;

namespace Common.Configuration
{
    public class Configuration : ConfigurationBase
    {
        public string IocpServer { get; set; }
        public int IocpPort { get; set; }

        public static Configuration Load()
        {
            return (Configuration)ConfigurationBase.Load(typeof(Configuration));
        }
    }
}
