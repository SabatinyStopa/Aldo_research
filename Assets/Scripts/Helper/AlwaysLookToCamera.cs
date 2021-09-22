using UnityEngine;

namespace PlatformGame.Helper{
    public class AlwaysLookToCamera : MonoBehaviour{
        Transform mainCameraTransform;

        void Start(){
            mainCameraTransform = Camera.main.transform;    
        }

        void Update(){
            transform.LookAt(mainCameraTransform);
        }        
    }
}