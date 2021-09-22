using UnityEngine;

namespace PlatformGame{
    public class Collectable : MonoBehaviour{
        [SerializeField] CollecatableKind collecatableKind;
        void OnTriggerEnter(Collider other) {
            if(other.CompareTag(Constants.PLAYER_TAG))  
                Collect();  
        }

        void Collect(){
            if(collecatableKind == CollecatableKind.MainCristal)
                GameManager.instance.hasMainCollectable = true;
            else
                GameManager.instance.SumCommonCristals();

            Destroy(gameObject);
        }
    }
}