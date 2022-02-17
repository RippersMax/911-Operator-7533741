using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
	public class Path
	{
		public List<Vector3> vectorPath;
		public Heuristic heuristic;
		public float heuristicScale;
		public int enabledTags;
	}
}
