using UnityEngine;
namespace PlatformGame{
    public class Bullet : MonoBehaviour{
        [Header("Velocidade")]
        [SerializeField] float speed = 20f;
        [Header("Dano")]
        [SerializeField] float damage = 20f;
        void Update(){
            MovimentHandler();
        }        
        void OnCollisionEnter(Collision other){
            Health health = other.collider.GetComponent<Health>();
            
            if(health)
                health.TakeDamage(damage);

            Destroy(gameObject);    
        }
        void OnBecameInvisible(){
            Destroy(gameObject);    
        }

        void MovimentHandler(){
            transform.position += transform.forward * Time.deltaTime * speed;
        }

    }
}