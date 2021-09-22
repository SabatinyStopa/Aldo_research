using UnityEngine;
namespace PlatformGame.Helper{
    public class Jiggle : MonoBehaviour{
        [Header("Velocidades")]
        // [SerializeField] float rotationSpeed = 5;
        [SerializeField] float upAndDownSpeed = 5;
        Vector3 startPosition;
        void Start(){
            startPosition = transform.position;    
        }
    
        void Update(){
            transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * upAndDownSpeed), transform.position.z);
        }
    }
}