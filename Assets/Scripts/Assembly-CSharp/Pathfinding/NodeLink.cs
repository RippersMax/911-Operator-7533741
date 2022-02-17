using UnityEngine;

namespace Pathfinding
{
	public class NodeLink : GraphModifier
	{
		public Transform end;
		public float costFactor;
		public bool oneWay;
		public bool deleteConnection;
	}
}
