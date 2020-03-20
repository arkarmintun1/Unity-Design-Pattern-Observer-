using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Observer1
{
    public class GameManager : MonoBehaviour
    {
        public Button btnEnemyAttack;
        public Button btnDrinkEnergyJuice;
        public Button btnKillEnemy;
    
        public Player player;
        public Healthbar healthbar;
        public Achievement achievement;
        
        // Start is called before the first frame update
        void Start()
        {
            btnEnemyAttack.onClick.AddListener(EnemyAttack);
            btnDrinkEnergyJuice.onClick.AddListener(DrinkEnergyJuice);
            btnKillEnemy.onClick.AddListener(KillEnemy);
            
            player.AddObserver(healthbar);
            player.AddObserver(achievement);
        }
    
        private void EnemyAttack()
        {
            player.EnemyAttack();
        }
    
        private void DrinkEnergyJuice()
        {
            player.DrinkEnergyJuice();
        }
    
        private void KillEnemy()
        {
            player.KillEnemy();
        }
    }
}
