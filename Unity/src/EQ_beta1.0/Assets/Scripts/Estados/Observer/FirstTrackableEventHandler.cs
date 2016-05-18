using UnityEngine;

namespace Vuforia
{
	/// <summary>
	/// A custom handler that implements the ITrackableEventHandler interface.
	/// </summary>
	public class FirstTrackableEventHandler: MonoBehaviour, ITrackableEventHandler

    {
        #region PRIVATE_MEMBER_VARIABLES

        private TrackableBehaviour mTrackableBehaviour;
        private int found = 0;

        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS

        #region PUBLIC_MEMBER_VARIABLES
        public State estado;

        //para identificar la marca y así saber que marca apareció o desapareció, debe ser distinto de 0
        public int enlace;
		#endregion // PRIVATE_MEMBER_VARIABLES


		#region PUBLIC_METHODS

		/// <summary>
		/// Implementation of the ITrackableEventHandler function called when the
		/// tracking state changes.
		/// </summary>
		public virtual void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus){
            if ((newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED))
            {
                Debug.Log("Encuentra");
                if (found == 0)
                {
                    found = 1;
                    estado.changeState(id);
                }
            }
            else if(found==1)
            {
                found = 0;
                estado.changeState(-id);
            }

        }

        #endregion // PUBLIC_METHODS



    }
}
