using UnityEngine;

namespace TouchScript.Gestures.Simple
{
	public class SimpleRotateGesture : TwoPointTransform2DGestureBase
	{
		[SerializeField]
		private float rotationThreshold;
	}
}
