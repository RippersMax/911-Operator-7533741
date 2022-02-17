using UnityEngine;

namespace Pathfinding
{
	public class NavGraph
	{
		public AstarPath active;
		public uint initialPenalty;
		public bool open;
		public uint graphIndex;
		public string name;
		public bool drawGizmos;
		public bool infoScreenOpen;
		public Matrix4x4 matrix;
		public Matrix4x4 inverseMatrix;
	}
}
