using UnityEngine;
using System.Collections;

namespace Vuforia{

	public class ButtonUIScript : MonoBehaviour, ITrackableEventHandler {

		#region PRIVATE_MEMBER_VARIABLES

		private TrackableBehaviour mTrackableBehaviour;

		#endregion // PRIVATE_MEMBER_VARIABLES

		public GameObject leftButton;
		public GameObject rightButton;
		public GameObject launchButton;
		public GameObject scoreText;
		public GameObject livesText;

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



		#region PUBLIC_METHODS

		/// <summary>
		/// Implementation of the ITrackableEventHandler function called when the
		/// tracking state changes.
		/// </summary>
		public void OnTrackableStateChanged(
			TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
				newStatus == TrackableBehaviour.Status.TRACKED ||
				newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
			{
				leftButton.SetActive (true);
				rightButton.SetActive (true);
				launchButton.SetActive (true);
				scoreText.SetActive (true);
				livesText.SetActive (true);

			}
			else
			{
				leftButton.SetActive (false);
				rightButton.SetActive (false);	
				launchButton.SetActive (false);
				scoreText.SetActive (false);
				livesText.SetActive (false);
			}
		}

		#endregion
	}
}