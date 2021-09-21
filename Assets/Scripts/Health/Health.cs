using UnityEngine;
using UnityEngine.UI;

namespace PlatformGame{
    public class Health : MonoBehaviour {
        [Header("Valor total de vida")]
        [SerializeField] float totalHealth = 100;
        [Header("Imagem da vida")]
        [SerializeField] Image healthImage;
        float currentLife;

        void Start(){
            currentLife = totalHealth;
            UpdateUi();    
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
            healthImage.fillAmount = currentLife / totalHealth;
        }

        void Die(){
            Debug.Log("Char died");
        }
    }
}