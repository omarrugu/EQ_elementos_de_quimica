using UnityEngine;
using System.Collections.Generic;

namespace Vuforia
{
    public class StateSubject : MonoBehaviour, Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public void notifyObservers()
        {
            foreach (Observer s in observers)
            {
                s.updateObserver(state);
            }
        }

        public void changeState(int state)
        {
            this.state = state;
            notifyObservers();
        }


        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }
    }
}