using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer1
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void Notify();
    
        int GetHealth();
        int GetKilledEnemy();
    }
}
