using UnityEngine;
namespace PlatformGame{
    public class PlayerHealth : Health{
        public override void Die(){
            GameManager.instance.PlayerDied();
            base.SetToTotalLife();
        }
    }
}