using UnityEngine;
namespace PlatformGame.Endlevel{
    public class EndLevelManager : MonoBehaviour{
        [Header("Canvas de fim de fase")]
        [SerializeField] GameObject endLevelCanvas;

        public delegate void EndLevelHandler();
        public static EndLevelHandler levelEnded; 

        void OnTriggerEnter(Collider other){
            if(other.CompareTag(Constants.PLAYER_TAG) && GameManager.instance.hasMainCollectable)    
                Deliver();
        }

        void Deliver(){
            levelEnded?.Invoke();
        }
    }
}