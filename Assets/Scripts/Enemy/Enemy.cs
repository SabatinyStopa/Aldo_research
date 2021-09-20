using UnityEngine;
namespace PlatformGame{
    public class Enemy : MonoBehaviour{
        [Header("Velocidade")]
        [SerializeField] float speed;
        [Header("Chcagem de chão")]
        [SerializeField] float groundCheckRadius;
        [SerializeField] Transform groundDetection;
        [SerializeField] LayerMask groundMask;
        [SerializeField] bool movingRight = true;
        [Header("Gizmos")]
        [SerializeField] bool enableGizmos;
        [SerializeField] Color gizmosColor = Color.magenta;

        void Update(){
            Patrol();    
        }

        void OnTriggerEnter(Collider other){
            // if(other.CompareTag("Player"))    
                // Damage Player;
        }
        void Patrol(){
            transform.position += transform.forward * Time.deltaTime * speed;
    
            if(!Physics.CheckSphere(groundDetection.position, groundCheckRadius, groundMask)){
                if(movingRight)
                    transform.eulerAngles = new Vector3(0, -90, 0);
                else
                    transform.eulerAngles = new Vector3(0, 90, 0);

                movingRight = !movingRight;
            }
                
        }     

        public void TakeDamage(float amount){

        }

        void OnDrawGizmos(){
            if(!enableGizmos)
                return;

            Gizmos.color = gizmosColor;
            Gizmos.DrawWireSphere(groundDetection.position, groundCheckRadius);

        }   
    }
}