using UnityEngine;

namespace Pathfinding
{
	public class NodeLink2 : GraphModifier
	{
		public Transform end;
		public float costFactor;
		public bool oneWay;
	}
}
