using UnityEngine;
namespace PlatformGame{
    public class PlayerAnimator : MonoBehaviour {
        [HideInInspector] public Animator animator;

        void Start(){
            animator = GetComponent<Animator>();    
        }

        public void SetMoviment(float horizontalValue){
            animator.SetFloat("Horizontal", Mathf.Abs(horizontalValue));
        }        
    }
}
