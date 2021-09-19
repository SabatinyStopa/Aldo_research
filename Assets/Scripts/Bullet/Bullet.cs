using UnityEngine;
namespace PlatformGame{
    public class Bullet : MonoBehaviour{
        [Header("Velocidade")]
        [SerializeField] float speed = 20f;
        void Update(){
            MovimentHandler();
        }        

        void OnCollisionEnter(Collision other) {
            Destroy(gameObject);    
        }

        void MovimentHandler(){
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        void OnBecameInvisible(){
            Destroy(gameObject);    
        }
    }
}