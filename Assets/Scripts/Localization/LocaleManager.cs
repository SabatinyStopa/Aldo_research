using UnityEngine.Localization.Settings;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

namespace PlatformGame{
    public class LocaleManager : MonoBehaviour{
        [SerializeField] TMP_Dropdown dropdown;

        IEnumerator Start(){
            yield return LocalizationSettings.InitializationOperation;

            var options = new List<TMP_Dropdown.OptionData>();
            int selected = 0;
            for (int i = 0; i < LocalizationSettings.AvailableLocales.Locales.Count; ++i){
                var locale = LocalizationSettings.AvailableLocales.Locales[i];
                if (LocalizationSettings.SelectedLocale == locale)
                    selected = i;
                options.Add(new TMP_Dropdown.OptionData(locale.name));
            }
            dropdown.options = options;
            dropdown.value = selected;
            dropdown.onValueChanged.AddListener(LocaleSelected);
        }

        static void LocaleSelected(int index){
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
        }
    }
}
