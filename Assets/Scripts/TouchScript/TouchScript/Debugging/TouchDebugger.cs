using UnityEngine;

namespace TouchScript.Debugging
{
	public class TouchDebugger : MonoBehaviour
	{
		[SerializeField]
		private bool showTouchId;
		[SerializeField]
		private bool showTags;
		[SerializeField]
		private Texture2D texture;
		[SerializeField]
		private bool useDPI;
		[SerializeField]
		private float touchSize;
		[SerializeField]
		private Color fontColor;
	}
}
