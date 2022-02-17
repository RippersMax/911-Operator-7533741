using TouchScript.Gestures;
using UnityEngine;

namespace TouchScript.Gestures.Simple
{
	public class Transform2DGestureBase : Gesture
	{
		public enum ProjectionType
		{
			Layer = 0,
			Local = 1,
			Global = 2,
		}

		[SerializeField]
		private ProjectionType projection;
		[SerializeField]
		private Vector3 projectionNormal;
	}
}
