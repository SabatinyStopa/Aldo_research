using UnityEngine;
using TMPro;
namespace PlatformGame.Endlevel{
    public class EndLevelManager : MonoBehaviour{
        [Header("Canvas de fim de fase")]
        [SerializeField] GameObject endLevelCanvas;
        [SerializeField] TextMeshProUGUI timeText;
        [SerializeField] TextMeshProUGUI cristalText;

        public delegate void EndLevelHandler();
        public static EndLevelHandler levelEnded; 

        void OnTriggerEnter(Collider other){
            if(other.CompareTag(Constants.PLAYER_TAG) && GameManager.instance.hasMainCollectable)    
                Deliver();
        }

        void SetTexts(){
            timeText.text = Helper.ConvertTime.ConvertedTime(GameManager.instance.timeInScene);
            cristalText.text = GameManager.instance.commonCristalQuantity.ToString();
        }
        void Deliver(){
            SetTexts();
            endLevelCanvas.SetActive(true);
            levelEnded?.Invoke();
        }
    }
}