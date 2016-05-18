using UnityEngine;
using System.Collections;
namespace Vuforia
{
    public interface Subject
    {

        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
