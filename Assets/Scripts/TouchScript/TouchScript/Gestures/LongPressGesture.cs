using UnityEngine;

namespace TouchScript.Gestures
{
	public class LongPressGesture : Gesture
	{
		[SerializeField]
		private int maxTouches;
		[SerializeField]
		private float timeToPress;
		[SerializeField]
		private float distanceLimit;
	}
}
