using UnityEngine;
namespace PlatformGame{
    public class EnemyHealth : Health{
        [Header("Parâmetro")]
        [SerializeField] string triggerHitName = "TakeDamage";
        Animator animator;

        void Start(){
            base.SetToTotalLife();
            animator = GetComponent<Animator>();
        }

        public override void TakeDamage(float amount){
            base.TakeDamage(amount);
            animator.SetTrigger(triggerHitName);
        }
    }
}