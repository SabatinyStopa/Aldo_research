using UnityEngine;
using TMPro;

namespace PlatformGame.Tutorial{
    public class TutorialManager : MonoBehaviour{
        [Header("Textos do tutorial")]
        [SerializeField] string[] tutorialQuotes;
        [Header("Texto")]
        [SerializeField] TextMeshProUGUI text;

        public void SetTextByIndex(){

        }
    }
}