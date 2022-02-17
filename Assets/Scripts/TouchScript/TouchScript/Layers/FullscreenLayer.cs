using UnityEngine;

namespace TouchScript.Layers
{
	public class FullscreenLayer : TouchLayer
	{
		public enum LayerType
		{
			MainCamera = 0,
			Camera = 1,
			Global = 2,
		}

		[SerializeField]
		private LayerType type;
		[SerializeField]
		private Camera _camera;
	}
}
