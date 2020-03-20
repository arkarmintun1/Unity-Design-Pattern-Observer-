using TMPro;
using UnityEngine;

namespace Observer2
{
    public class Potion: MonoBehaviour
    {
        public TextMeshProUGUI txtPotion;
        
        private void OnEnable()
        {
            Player.OnEnemyAttacked += CheckHealth;
            Player.OnDrinkEnergyJuice += CheckHealth;
        }

        private void OnDisable()
        {
            Player.OnEnemyAttacked -= CheckHealth;
            Player.OnDrinkEnergyJuice -= CheckHealth;
        }

        private void CheckHealth()
        {
            txtPotion.text = Player.health < 20 ? "Health is low. Health potion is available." : "";
        }
    }
}