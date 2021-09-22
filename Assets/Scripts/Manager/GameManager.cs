using UnityEngine;
namespace PlatformGame{
    public class GameManager : MonoBehaviour {
        public static GameManager instance;
        public int commonCristalQuantity = 0;
        [HideInInspector] public bool hasMainCollectable;
        [HideInInspector] public bool playerCantMove;

        void Awake(){
            if(!instance)
                instance = this;    
            else
                Destroy(gameObject);
        }

        public void SumCommonCristals(){
            commonCristalQuantity++;
        }
    }
}