using UnityEngine;
using System.Collections;
namespace Vuforia
{
    public class StateObserver : MonoBehaviour, Observer
    {
        public StateSubject ts;
        private int state;
        private BehavioursManager bm;
        void Start()
        {
            ts.registerObserver(this);
            bm = GetComponent<BehavioursManager>();
        }
        public void updateObserver(int state)
        {
            this.state = state;
            Debug.Log("Cambio de estado " + state);
            bm.changeByState(state);

        }

        public int getState()
        {
            return state;
        }
    }
}