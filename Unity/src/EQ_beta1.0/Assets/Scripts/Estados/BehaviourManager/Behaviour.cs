using UnityEngine;
using System.Collections;

namespace Vuforia
{
    public abstract class Behaviour: MonoBehaviour
    {
        protected bool isActive = false;
        public abstract void active();
        public abstract void disable();
        protected abstract void realizaComportamiento();

        void update()
        {
            if (isActive)
            {
                realizaComportamiento();
            }
        }

        public abstract string getName();

        public bool activated()
        {
            return isActive;
        }
    }
}