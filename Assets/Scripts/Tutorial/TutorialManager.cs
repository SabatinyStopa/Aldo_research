using PlatformGame.Helper;
using UnityEngine;
using TMPro;

namespace PlatformGame.Tutorial{
    public class TutorialManager : MonoBehaviour{
        [Header("Textos do tutorial")]
        [SerializeField] string[] tutorialQuotes;
        [Header("Texto")]
        [SerializeField] TextMeshProUGUI text;
        [Header("Canvas do tutorial")]
        [SerializeField] GameObject tutorialCanvas;
        int counter;
        void Start(){
            counter = 0;
            text.text = tutorialQuotes[counter];
            text.StartCoroutine(text.GetComponent<TextTypeEffect>().StartTyping());
            GameManager.instance.playerCantMove = true;
        }

        public void AdvanceTutorial(){
            counter++;
            if(counter >= tutorialQuotes.Length)
                EndTutorial();
            else{
                text.text = tutorialQuotes[counter];
                text.StartCoroutine(text.GetComponent<TextTypeEffect>().StartTyping());
            }
        }

        void EndTutorial(){
            tutorialCanvas.SetActive(false);
            GameManager.instance.playerCantMove = false;
        }
    }
}