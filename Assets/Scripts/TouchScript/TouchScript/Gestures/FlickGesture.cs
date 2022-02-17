using UnityEngine;

namespace TouchScript.Gestures
{
	public class FlickGesture : Gesture
	{
		public enum GestureDirection
		{
			Any = 0,
			Horizontal = 1,
			Vertical = 2,
		}

		[SerializeField]
		private float flickTime;
		[SerializeField]
		private float minDistance;
		[SerializeField]
		private float movementThreshold;
		[SerializeField]
		private GestureDirection direction;
	}
}
