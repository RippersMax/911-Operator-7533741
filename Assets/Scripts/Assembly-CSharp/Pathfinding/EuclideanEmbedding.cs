using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class EuclideanEmbedding
	{
		public HeuristicOptimizationMode mode;
		public int seed;
		public Transform pivotPointRoot;
		public int spreadOutCount;
	}
}
