using UnityEngine;
using System.Collections.Generic;
using TouchScript.Layers;

namespace TouchScript
{
	public class TouchManager : MonoBehaviour
	{
		public enum MessageType
		{
			FrameStarted = 1,
			FrameFinished = 2,
			TouchesBegan = 4,
			TouchesMoved = 8,
			TouchesEnded = 16,
			TouchesCancelled = 32,
		}

		[SerializeField]
		private Object displayDevice;
		[SerializeField]
		private bool shouldCreateCameraLayer;
		[SerializeField]
		private bool useSendMessage;
		[SerializeField]
		private MessageType sendMessageEvents;
		[SerializeField]
		private GameObject sendMessageTarget;
		[SerializeField]
		private List<TouchLayer> layers;
	}
}
