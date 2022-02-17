using UnityEngine;

namespace TouchScript.Behaviors
{
	public class FullscreenTarget : MonoBehaviour
	{
		public enum TargetType
		{
			Background = 0,
			Foreground = 1,
		}

		public TargetType Type;
	}
}
