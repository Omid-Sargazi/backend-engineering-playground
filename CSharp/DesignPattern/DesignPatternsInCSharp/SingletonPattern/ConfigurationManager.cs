using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.SingletonPattern
{
    public class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        private Dictionary<string, string> _settings;

        private ConfigurationManager()
        {
            _settings = new Dictionary<string, string>();
        }

        public static ConfigurationManager Instance => _instance.Value;

        public void Set(string key, string value)
        {
            _settings[key] = value;
        }

        public string Get(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key] : null;
        }
    }

}
