using UnityEngine;
using System.Collections.Generic;

namespace Vuforia
{
    public abstract class BehavioursManager : MonoBehaviour
    {
        protected Behaviour[] behaviors;
        // Use this for initialization
        void Start()
        {
            behaviors = GetComponents<Behaviour>();
        }

        public abstract void changeByState(int state);

        protected void activeBehaviour(string name)
        {
            foreach (Behaviour b in behaviors)
            {
                if (string.Compare((b.getName()), name) == 0)
                    b.active();
            }
        }

        protected void disableBehaviours()
        {
            foreach (Behaviour b in behaviors)
            {
                if (b.activated())
                    b.disable();
            }
        }
    }
}