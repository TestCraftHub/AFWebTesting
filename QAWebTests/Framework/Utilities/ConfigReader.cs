using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebTests.Framework.Utilities
{
    public class ConfigReader
    {
        private static Config _config;
        public ConfigReader()
        {
            string json = File.ReadAllText(@"D:\StudyPractice\WebAF\AFWebTesting\QAWebTests\Config\appsettings.json");

            _config = JsonConvert.DeserializeObject<Config>(json);
        
        }

        public Config GetConfig()
        {
            return _config;
        }
    }
}
