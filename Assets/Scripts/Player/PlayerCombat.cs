using UnityEngine;

namespace PlatformGame.Player{
    public class PlayerCombat : MonoBehaviour {
        [Header("Ponto de Tiro")]
        [SerializeField] Transform pointOfShoot;
        [Header("Munição")]
        [SerializeField] GameObject bulletPrefab;
        [Header("Tempo entre os disparos")]
        [SerializeField] float timeToShoot = 0.3f;
        [Header("Particulas")]
        [SerializeField] GameObject shootLightPrefab;
        float currentTimer;
        PlayerAnimator playerAnimator;
        bool canShoot;
        [Header("Modo debug")]
        [SerializeField] bool debugMode;

        void Start() {
            playerAnimator = GetComponent<PlayerAnimator>();    
        }

        void Update(){
            if(GameManager.instance.playerCantMove)
                return;
                
            ShootHandler();
        }

        public void SetCanShoot(bool active){
            canShoot = active;
        }

        void ShootHandler(){
            if(debugMode)
                canShoot = Input.GetKeyDown(KeyCode.E);
    
            if(canShoot && currentTimer >= timeToShoot){
                currentTimer = 0;
                Shoot();
                playerAnimator.SetIsShooting(true);
            }
            currentTimer += Time.deltaTime;
        }

        void Shoot(){
            Instantiate(shootLightPrefab, pointOfShoot.position, Quaternion.identity);
            Instantiate(bulletPrefab, pointOfShoot.position, pointOfShoot.transform.rotation);
        }
    }
}