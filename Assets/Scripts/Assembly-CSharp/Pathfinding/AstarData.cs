using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class AstarData
	{
		[SerializeField]
		private string dataString;
		[SerializeField]
		private byte[] upgradeData;
		public byte[] data_backup;
		public TextAsset file_cachedStartup;
		public byte[] data_cachedStartup;
		[SerializeField]
		public bool cacheStartup;
	}
}
