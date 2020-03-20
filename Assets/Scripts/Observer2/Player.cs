using System;
using UnityEngine;
using UnityEngine.UI;

namespace Observer2
{
    public class Player: MonoBehaviour
    {
        public static int health = 100;
        public static int killedEnemies = 0;
        
        public Button btnEnemyAttack;
        public Button btnDrinkEnergyJuice;
        public Button btnKillEnemy;

        // public delegate void AttackedByEnemy();
        // public static event AttackedByEnemy OnEnemyAttacked;
        //
        // public delegate void DrinkEnergyJuice();
        // public static event DrinkEnergyJuice OnDrinkEnergyJuice;
        //
        // public delegate void KillEnemy();
        // public static event KillEnemy OnKillEnemy;

        public static event Action OnEnemyAttacked;
        public static event Action OnDrinkEnergyJuice;
        public static event Action OnKillEnemy;

        void Start()
        {
            btnEnemyAttack.onClick.AddListener(OnClickEnemyAttack);
            btnDrinkEnergyJuice.onClick.AddListener(OnClickDrinkEnergyJuice);
            btnKillEnemy.onClick.AddListener(OnClickKillEnemy);
        }
    
        private void OnClickEnemyAttack()
        {
            health -= 10;
            OnEnemyAttacked?.Invoke();
        }
    
        private void OnClickDrinkEnergyJuice()
        {
            health += 5;
            OnDrinkEnergyJuice?.Invoke();
        }
    
        private void OnClickKillEnemy()
        {
            killedEnemies++;
            OnKillEnemy?.Invoke();
        }
    }
}