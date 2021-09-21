using UnityEngine;

namespace PlatformGame.Player{
    public class PlayerMoviment : MonoBehaviour{
        [Header("Velocidade")]
        [SerializeField] float speed;
        [Header("Gravidade")]
        [SerializeField] float gravity;
        [Header("Altura do Pulo")]
        [SerializeField] float jumpHeight;
        [Header("Rotação do Personagem")]
        [SerializeField] float turnSmoothTime = 0.1f;
        [SerializeField] float turnSmoothVelocity;
        [Header("Checagem do chão")]
        [SerializeField] Transform groundChecker;
        [SerializeField] float groundCheckRadius = 0.2f;
        [SerializeField] LayerMask groundMask;
        CharacterController characterController;
        Vector3 playerVelocity;
        bool isGrounded;
        PlayerAnimator playerAnimator;
        [Header("Gizmos")]
        [SerializeField] bool enableGizmos;
        [SerializeField] Color gizmosColor = Color.blue;

        void Start(){
            characterController = GetComponent<CharacterController>();
            playerAnimator = GetComponent<PlayerAnimator>();    
        }

        void Update(){
            MovimentHandler();
            JumpHandler();
        }

        void JumpHandler(){
            isGrounded = Physics.CheckSphere(groundChecker.position, groundCheckRadius, groundMask);

            playerAnimator.SetIsGrounded(isGrounded);

            if (isGrounded && playerVelocity.y < 0)
                playerVelocity.y = 0f;

            if (Input.GetButtonDown("Jump") && isGrounded){
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
                playerAnimator.SetJump();
            }

            playerVelocity.y += gravity * Time.deltaTime;
            characterController.Move(playerVelocity * Time.deltaTime);
        }
        void MovimentHandler(){
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 move = new Vector3(horizontalInput, 0, 0);
            if(isGrounded)
                playerAnimator.SetMoviment(horizontalInput);
            RotationHandler(horizontalInput);
            characterController.Move(move * Time.deltaTime * speed);
        }

        void RotationHandler(float horizontalInput){
            Vector3 direction = new Vector3(horizontalInput, 0f, 0f).normalized;

            if(direction.magnitude >= 0.1f){
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            }            
        }

        void OnDrawGizmos(){
            if(!enableGizmos)
                return;

            Gizmos.color = gizmosColor;
            Gizmos.DrawWireSphere(groundChecker.position, groundCheckRadius);    
        }
    }
}