using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Observer1
{
    public class Achievement : MonoBehaviour, IObserver
    {
        public TextMeshProUGUI txtKilledEnemy;
    
        public TextMeshProUGUI txtEnemyKillAchievement;
        
        public void OnNotify(IObservable player)
        {
            txtKilledEnemy.text = $"You've killed {player.GetKilledEnemy()} enemies.";
    
            if (player.GetKilledEnemy() > 10)
            {
                txtEnemyKillAchievement.text = $"Congratulations! You've unlocked master killer badge";
            }
        }
    }
}
