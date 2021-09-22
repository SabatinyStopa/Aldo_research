using UnityEngine;
using UnityEngine.Advertisements;
namespace PlatformGame{
    public class AdsManager : MonoBehaviour{
        [Header("Posição")]
        [SerializeField] BannerPosition bannerPosition = BannerPosition.TOP_LEFT;
        [Header("Id")]
        [SerializeField] string androidAdUnitId = "Banner_Android";

        void Start(){
            Advertisement.Banner.SetPosition(bannerPosition);
            Advertisement.Banner.Load(androidAdUnitId);
            Advertisement.Banner.Show(androidAdUnitId);
        }
    }
}