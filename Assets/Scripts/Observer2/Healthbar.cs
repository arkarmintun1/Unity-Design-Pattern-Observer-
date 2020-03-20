using System;
using TMPro;
using UnityEngine;

namespace Observer2
{
    public class Healthbar: MonoBehaviour
    {
        public TextMeshProUGUI txtPlayerHealth;
        
        private void OnEnable()
        {
            Player.OnEnemyAttacked += OnEnemyAttacked;
            Player.OnDrinkEnergyJuice += OnDrinkEnergyJuice;
        }

        private void OnDisable()
        {
            Player.OnEnemyAttacked -= OnEnemyAttacked;
            Player.OnDrinkEnergyJuice -= OnDrinkEnergyJuice;
        }

        private void OnEnemyAttacked()
        {
            txtPlayerHealth.text = $"Player Health: {Player.health}";
        }

        private void OnDrinkEnergyJuice()
        {
            txtPlayerHealth.text = $"Player Health: {Player.health}";
        }
    }
}