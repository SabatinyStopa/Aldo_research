using UnityEngine.Localization.Components;
using System.Collections;
using UnityEngine;
using TMPro;
namespace PlatformGame.Helper{
    public class TextTypeEffect : MonoBehaviour {
        [Header("Time Of Characters")]
        [Tooltip("Time To Wait Between each char in the text")]
        [SerializeField] float timeToWaitBetweenChars = 0.01f;
    
        public IEnumerator StartTyping(){
            TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
            LocalizeStringEvent localizeStringEvent = GetComponent<LocalizeStringEvent>();
            localizeStringEvent.StringReference.SetReference("Ui", text.text);
            text.enabled = false;
            yield return new WaitForSecondsRealtime(0.8f);
            string allText = text.text;
            text.text = "";
            text.enabled = true;

            foreach (char letter in allText){
                text.text += letter;
                yield return new WaitForSecondsRealtime(timeToWaitBetweenChars);
            }
        }
    }
}