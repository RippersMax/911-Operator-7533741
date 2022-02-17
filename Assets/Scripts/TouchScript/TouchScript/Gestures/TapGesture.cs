using UnityEngine;

namespace TouchScript.Gestures
{
	public class TapGesture : Gesture
	{
		[SerializeField]
		private int numberOfTapsRequired;
		[SerializeField]
		private float timeLimit;
		[SerializeField]
		private float distanceLimit;
	}
}
