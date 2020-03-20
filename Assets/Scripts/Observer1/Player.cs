using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Observer1
{
    public class Player : MonoBehaviour, IObservable
    {
        public int health = 100;
        public int killedEnemy = 0;
    
        private List<IObserver> observers = new List<IObserver>();
    
        private void Start()
        {
            Notify();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.OnNotify(this);
            }
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetKilledEnemy()
        {
            return killedEnemy;
        }
    

        public void EnemyAttack()
        {
            health = health - 10;
            Notify();
        }

        public void DrinkEnergyJuice()
        {
            health = health + 5;
            Notify();
        }

        public void KillEnemy()
        {
            killedEnemy++;
            Notify();
        }
    }

}