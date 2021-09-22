using UnityEngine;
namespace PlatformGame{
    public class GameManager : MonoBehaviour {
        public static GameManager instance;
        [HideInInspector] public int commonCristalQuantity = 0;
        [HideInInspector] public float timeInScene;
        [HideInInspector] public bool hasMainCollectable;
        [HideInInspector] public bool playerCantMove;
        public delegate void OnDeathHandler();
        public OnDeathHandler onDeath;

        void Awake(){
            if(!instance)
                instance = this;    
            else
                Destroy(gameObject);
        }

        void Start(){
            Endlevel.EndLevelManager.levelEnded += StopPlayer;
        }
        void Update(){
            SetCurrentTime();
        }
        public void PlayerDied(){
            onDeath?.Invoke();
        }
        void SetCurrentTime(){
            timeInScene += Time.deltaTime;
        }
        void StopPlayer(){
            playerCantMove = true;
        }

        public void SumCommonCristals(){
            commonCristalQuantity++;
        }
    }
}