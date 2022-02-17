using UnityEngine;

namespace TouchScript.Gestures.Simple
{
	public class SimplePanGesture : Transform2DGestureBase
	{
		[SerializeField]
		private float movementThreshold;
	}
}
