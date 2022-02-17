using UnityEngine;
using System;
using UnityEngine.Events;

namespace Tacticsoft
{
	public class TableView : MonoBehaviour
	{
		[Serializable]
		public class CellVisibilityChangeEvent : UnityEvent<int, bool>
		{
		}

		public CellVisibilityChangeEvent onCellVisibilityChanged;
	}
}
