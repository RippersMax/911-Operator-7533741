using UnityEngine;

namespace Pathfinding
{
	public class PointNode : GraphNode
	{
		public PointNode(AstarPath astar) : base(default(AstarPath))
		{
		}

		public GameObject gameObject;
	}
}
