using System;
using UnityEngine;

namespace Call911.Assets
{
	[Serializable]
	public class PrefabSetItem
	{
		public PrefabSetItem(GameObject prefab)
		{
		}

		public GameObject Prefab;
		public bool IsPooled;
		public int InitialPool;
		public int MaxPool;
	}
}
