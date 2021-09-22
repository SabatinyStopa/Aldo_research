using UnityEngine;

namespace PlatformGame.Player{
    public class PlayerCombat : MonoBehaviour {
        [Header("Ponto de Tiro")]
        [SerializeField] Transform pointOfShoot;
        [SerializeField] GameObject bulletPrefab;
        [Header("Tempo entre os disparos")]
        [SerializeField] float timeToShoot = 0.3f;
        float currentTimer;
        PlayerAnimator playerAnimator;

        void Start() {
            playerAnimator = GetComponent<PlayerAnimator>();    
        }

        void Update(){
            if(GameManager.instance.playerCantMove)
                return;
                
            ShootHandler();
        }

        void ShootHandler(){
            if(Input.GetKeyDown(KeyCode.E) && currentTimer >= timeToShoot){
                currentTimer = 0;
                Shoot();
                playerAnimator.SetIsShooting(true);
            }
            currentTimer += Time.deltaTime;
        }

        void Shoot(){
            Instantiate(bulletPrefab, pointOfShoot.position, pointOfShoot.transform.rotation);
        }
    }
}