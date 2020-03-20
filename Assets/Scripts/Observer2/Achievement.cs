using System;
using TMPro;
using UnityEngine;

namespace Observer2
{
    public class Achievement: MonoBehaviour
    {
        public TextMeshProUGUI txtKilledEnemy;
        public TextMeshProUGUI txtEnemyKillAchievement;

        private void OnEnable()
        {
            Player.OnKillEnemy += OnKillEnemy;
        }

        private void OnDisable()
        {
            Player.OnKillEnemy -= OnKillEnemy;
        }

        private void OnKillEnemy()
        {
            txtKilledEnemy.text = $"You've killed {Player.killedEnemies} enemies.";
    
            if (Player.killedEnemies > 10)
            {
                txtEnemyKillAchievement.text = $"Congratulations! You've unlocked master killer badge";
            }
        }
    }
}