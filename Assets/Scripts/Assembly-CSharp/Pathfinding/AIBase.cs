using UnityEngine;

namespace Pathfinding
{
	public class AIBase : VersionedMonoBehaviour
	{
		public Vector3 gravity;
		public LayerMask groundMask;
		public float centerOffset;
		public bool rotationIn2D;
	}
}
