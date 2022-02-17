using UnityEngine;

namespace Pathfinding
{
	public class NavmeshBase : NavGraph
	{
		public Vector3 forcedBoundsSize;
		public bool showMeshOutline;
		public bool showNodeConnections;
		public bool showMeshSurface;
		public int tileXCount;
		public int tileZCount;
		public bool nearestSearchOnlyXZ;
	}
}
