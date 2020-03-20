using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer1
{
    public interface IObserver
    {
        void OnNotify(IObservable player);
    }
}