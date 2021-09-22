using UnityEngine;
namespace PlatformGame{
    public class EnemyHealth : Health{
        [Header("Parâmetro")]
        [SerializeField] string triggerHitName = "TakeDamage";
        [Header("Prefab para morte")]
        [SerializeField] GameObject plasmaExplosionPrefab;
        Animator animator;

        void Start(){
            base.SetToTotalLife();
            animator = GetComponent<Animator>();
        }

        public override void TakeDamage(float amount){
            base.TakeDamage(amount);
            animator.SetTrigger(triggerHitName);
        }

        public override void Die(){
            Instantiate(plasmaExplosionPrefab, transform.position + Vector3.up / 2, Quaternion.identity);
            base.Die();
        }
    }
}