using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Observer1
{
    public class Healthbar : MonoBehaviour, IObserver
    {
        public TextMeshProUGUI txtPlayerHealth;
        
        public void OnNotify(IObservable player)
        {
            txtPlayerHealth.text = $"Player Health: {player.GetHealth()}";
        }
    }
}
