using TMPro;
using UnityEngine;

namespace UnluckyLocalization.Runtime
{
    [RequireComponent(typeof(TMP_Text))]
    public class Localization : MonoBehaviour
    {
        [SerializeField] private string _key;

        private LocalizationService _localizationService;

        private void Start()
        {
            _localizationService = LocalizationManager.Instance.LocalizationService;
            GetComponent<TMP_Text>().text = _localizationService.Get(_key);
        }
    }
}