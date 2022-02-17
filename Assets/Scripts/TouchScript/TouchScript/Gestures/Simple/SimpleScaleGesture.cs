using UnityEngine;

namespace TouchScript.Gestures.Simple
{
	public class SimpleScaleGesture : TwoPointTransform2DGestureBase
	{
		[SerializeField]
		private float scalingThreshold;
	}
}
