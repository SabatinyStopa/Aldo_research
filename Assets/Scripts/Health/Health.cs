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
            SetToTotalLife(); 
        }

        public void SetToTotalLife(){
            currentLife = totalHealth;
            UpdateUi();
        }
        public virtual void TakeDamage(float amount){
            currentLife -= amount;

            if(currentLife <= 0)
                Die();

            if(currentLife >= totalHealth)
                currentLife = totalHealth;

            UpdateUi();
        }

        void UpdateUi(){
            healthImage.fillAmount = currentLife / totalHealth;
        }

        public virtual void Die(){
            Destroy(gameObject);
        }
    }
}