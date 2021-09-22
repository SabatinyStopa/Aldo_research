using System.Collections;
using UnityEngine;

namespace PlatformGame.Helper{
    public class DestroyMeAfterTime : MonoBehaviour {
        [Header("Tempo")]
        [SerializeField] float timeToDestroy = 3f;
        void Start(){
            StartCoroutine(DestroyMe());
        }

        IEnumerator DestroyMe(){
            yield return new WaitForSeconds(timeToDestroy);
            Destroy(gameObject);
        }
    }
}