using UnityEngine;
namespace PlatformGame{
    public class DeliverMainCollectable : MonoBehaviour {
        void OnTriggerEnter(Collider other) {
            if(other.CompareTag(Constants.PLAYER_TAG) && GameManager.instance.hasMainCollectable)    
                Deliver();
        }

        void Deliver(){
            Debug.Log("Delivered");
        }
    }
}