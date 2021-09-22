using UnityEngine;
namespace PlatformGame.Helper{
    public class DeadZone : MonoBehaviour{
        GameObject player;
        Vector3 playerStartingPosition;

        void Start() {
            player = GameObject.FindGameObjectWithTag(Constants.PLAYER_TAG);
            playerStartingPosition = player.transform.position;
            GameManager.instance.onDeath += ResetPlayerPosition;
        }

        void OnTriggerEnter(Collider other){
            if(other.CompareTag(Constants.PLAYER_TAG))
                GameManager.instance.PlayerDied();    
        }

        void ResetPlayerPosition(){
            player.SetActive(false);
            player.transform.position = playerStartingPosition;
            player.SetActive(true);
        }
    }
}
