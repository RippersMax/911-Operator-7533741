using UnityEngine;

namespace TouchScript.Gestures.Simple
{
	public class TwoPointTransform2DGestureBase : Transform2DGestureBase
	{
		[SerializeField]
		private float minPointsDistance;
	}
}
