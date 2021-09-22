using UnityEngine;
namespace PlatformGame.Player{
    public class PlayerLanding : StateMachineBehaviour{
        [Header("Particula")]
        [SerializeField] GameObject targetParticle;
        
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
            Instantiate(targetParticle, animator.GetComponent<Transform>());
        }
    }
}