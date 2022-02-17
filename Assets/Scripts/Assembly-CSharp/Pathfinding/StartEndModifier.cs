using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class StartEndModifier : PathModifier
	{
		public enum Exactness
		{
			SnapToNode = 0,
			Original = 1,
			Interpolate = 2,
			ClosestOnNode = 3,
			NodeConnection = 4,
		}

		public bool addPoints;
		public Exactness exactStartPoint;
		public Exactness exactEndPoint;
		public bool useRaycasting;
		public LayerMask mask;
		public bool useGraphRaycasting;
	}
}
