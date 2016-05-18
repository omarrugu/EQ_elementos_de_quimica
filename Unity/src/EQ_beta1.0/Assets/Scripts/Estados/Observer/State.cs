using UnityEngine;

namespace Vuforia
{
    public abstract class State : MonoBehaviour
    {
        public StateSubject subject;
        protected int state;

        public abstract void changeState(int state);

        public abstract int getState();
    }
}