using UnityEngine;
using System.Collections.Generic;

namespace TouchScript.Gestures
{
	public class Gesture : MonoBehaviour
	{
		[SerializeField]
		private bool advancedProps;
		[SerializeField]
		private bool combineTouches;
		[SerializeField]
		private float combineTouchesInterval;
		[SerializeField]
		private bool useSendMessage;
		[SerializeField]
		private bool sendStateChangeMessages;
		[SerializeField]
		private GameObject sendMessageTarget;
		[SerializeField]
		private Gesture requireGestureToFail;
		[SerializeField]
		private List<Gesture> friendlyGestures;
	}
}
