using UnityEngine;
namespace PlatformGame{
    public class Health : MonoBehaviour {
        [Header("Valor total de vida")]
        [SerializeField] float totalHealth = 100;
        float currentLife;

        void Start() {
            currentLife = totalHealth;    
        }
        public void TakeDamage(float amount){
            currentLife -= amount;
            //Take hit animation
            if(currentLife <= 0)
                Die();

            if(currentLife >= totalHealth)
                currentLife = totalHealth;

            UpdateUi();
        }

        void UpdateUi(){
            
        }

        void Die(){
            Debug.Log("Char died");
        }
    }
}