using UnityEngine.EventSystems;
using UnityEngine;

namespace TouchScript.Behaviors
{
	public class TouchScriptInputModule : BaseInputModule
	{
		public override void Process()
		{
		}

		[SerializeField]
		private string horizontalAxis;
		[SerializeField]
		private string verticalAxis;
		[SerializeField]
		private string submitButton;
		[SerializeField]
		private string cancelButton;
		[SerializeField]
		private float inputActionsPerSecond;
	}
}
