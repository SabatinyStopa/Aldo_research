using UnityEngine;
using TMPro;
namespace PlatformGame.Helper{
    public class ShineText : MonoBehaviour{
        [Header("Cor para brilhar")]
        [SerializeField] Color fromColor = Color.white;
        [SerializeField] Color ToColor = Color.blue;
        TextMeshProUGUI text;

        void Start(){
            text = GetComponent<TextMeshProUGUI>();    
        }

        void Update(){
            ChangeColorHander();    
        }
        void ChangeColorHander(){
            text.color = Color.Lerp(fromColor, ToColor, Mathf.PingPong(Time.time, 1));
        }
    }
}