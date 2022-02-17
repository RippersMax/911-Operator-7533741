using UnityEngine;

namespace Unitycoding.UIWidgets
{
	public class TooltipTrigger : MonoBehaviour
	{
		[SerializeField]
		private string instanceName;
		public bool displayed;
		[SerializeField]
		private bool showBackground;
		[SerializeField]
		public float width;
		[SerializeField]
		private Color color;
		[TextAreaAttribute]
		public string tooltip;
		public Sprite icon;
	}
}
