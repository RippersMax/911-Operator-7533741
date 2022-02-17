using UnityEngine;
using System;
using UnityEngine.Events;
using System.Collections.Generic;

namespace Unitycoding.UIWidgets
{
	public class UIWidget : MonoBehaviour
	{
		[Serializable]
		public class WidgetEvent : UnityEvent
		{
		}

		[Serializable]
		public class Entry
		{
			public UIWidget.TriggerType eventID;
			public UIWidget.WidgetEvent callback;
		}

		public enum TriggerType
		{
			OnShow = 0,
			OnClose = 1,
			OnTweenFinished = 2,
		}

		[SerializeField]
		private new string name;
		[SerializeField]
		private bool focus;
		[SerializeField]
		private EasingEquations.EaseType easeType;
		[SerializeField]
		private float duration;
		public AudioClip showSound;
		public AudioClip closeSound;
		[SerializeField]
		private List<UIWidget.Entry> m_Delegates;
		public WidgetEvent onShow;
		public WidgetEvent onClose;
		public WidgetEvent onTweenFinished;
	}
}
