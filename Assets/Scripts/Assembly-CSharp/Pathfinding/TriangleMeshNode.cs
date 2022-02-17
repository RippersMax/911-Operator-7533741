namespace Pathfinding
{
	public class TriangleMeshNode : MeshNode
	{
		public TriangleMeshNode(AstarPath astar) : base(default(AstarPath))
		{
		}

		public int v0;
		public int v1;
		public int v2;
	}
}
