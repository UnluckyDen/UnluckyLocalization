using System.Collections.Generic;

namespace UnluckyLocalization.Runtime
{
    public class LocalizationService
    {
        private Dictionary<string, string> _localizationContainer;
        
        public string LanguageCode { get; private set; }

        public void SetLanguage(string languageCode, Dictionary<string, string> localization)
        {
            _localizationContainer = localization;
            LanguageCode = languageCode;
        }

        public string Get(string key) => 
            _localizationContainer.TryGetValue(key, out var value) ? value.Replace("\\n", "\n") : key;

        public string Get(string key, params object[] args) => 
            string.Format(Get(key), args);
    }
}