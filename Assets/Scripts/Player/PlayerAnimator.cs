using UnityEngine;
namespace PlatformGame{
    public class PlayerAnimator : MonoBehaviour {
        [Header("Parametros")]
        [SerializeField] string horizontal = "Horizontal";
        [SerializeField] string isGrounded = "IsGrounded";
        [SerializeField] string jump = "Jump";
        Animator animator;

        void Start(){
            animator = GetComponent<Animator>();    
        }

        public void SetMoviment(float horizontalValue){
            animator.SetFloat(horizontal, Mathf.Abs(horizontalValue));
        }
        public void SetIsGrounded(bool grounded){
            animator.SetBool(isGrounded, grounded);
        }  
        public void SetJump(){
            animator.SetTrigger(jump);
        }      
    }
}
