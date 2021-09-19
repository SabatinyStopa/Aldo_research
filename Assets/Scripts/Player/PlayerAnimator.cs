using System;
using UnityEngine;
namespace PlatformGame{
    public class PlayerAnimator : MonoBehaviour {
        [Header("Parametros")]
        [SerializeField] string horizontal = "Horizontal";
        [SerializeField] string isGrounded = "IsGrounded";
        [SerializeField] string isShooting = "IsShooting";
        [SerializeField] string jump = "Jump";
        [Header("Tempos")]
        [SerializeField] float timeToSetShootingBack = 3f;
        float currentShootingTime;
        Animator animator;

        void Start(){
            animator = GetComponent<Animator>();    
        }

        void Update() {
            IsShootingHandler();
        }

        void IsShootingHandler(){
            currentShootingTime += Time.deltaTime;

            if(currentShootingTime >= timeToSetShootingBack)
                SetIsShooting(false);
        }

        public void SetMoviment(float horizontalValue){
            animator.SetFloat(horizontal, Mathf.Abs(horizontalValue));
        }
        public void SetIsGrounded(bool grounded){
            animator.SetBool(isGrounded, grounded);
        }

        public void SetIsShooting(bool active){
            if(active)
                currentShootingTime = 0;

            animator.SetBool(isShooting, active);
        }

        public void SetJump(){
            animator.SetTrigger(jump);
        }      
    }
}
