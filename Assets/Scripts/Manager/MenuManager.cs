using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlatformGame{
    public class MenuManager : MonoBehaviour{
        [Header("Índice da cena para carregar")]
        [SerializeField] int targetSceneIndexToLoad = 1;
        public void LoadTargetScene(){
            SceneManager.LoadScene(targetSceneIndexToLoad);
        }   

        public void Quit(){
            Application.Quit();
        }     
    }
}