using UnityEngine;
using UnluckyLocalization.Editor;

namespace UnluckyLocalization.Runtime
{
    public class LocalizationManager : MonoBehaviour
    {
        [SerializeField] private string _countryCode;
        
        private LocalizationSettings _localizationSettings;
        private LocalizationService _localizationService;
        public static LocalizationManager Instance { get; private set; }
        public LocalizationService LocalizationService => _localizationService;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else if (Instance == this)
                Destroy(gameObject);
            
            DontDestroyOnLoad(gameObject);

            Initialize();
        }

        private void Initialize()
        {
            _localizationService = new LocalizationService();
            _localizationSettings = EditorSettingsUtility.Load<LocalizationSettings>(LocalizationSettings.FileName);
            
             TextAsset textAsset = Resources.Load(_localizationSettings.InternalFolder + _countryCode) as TextAsset;
            
            _localizationService.SetLanguage(_countryCode, LocalizationParser.ParseToDictionary(textAsset.text));
        }
    }
}