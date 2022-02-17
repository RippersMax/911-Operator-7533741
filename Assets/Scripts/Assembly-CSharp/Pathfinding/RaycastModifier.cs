using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class RaycastModifier : MonoModifier
	{
		public bool useRaycasting;
		public LayerMask mask;
		public bool thickRaycast;
		public float thickRaycastRadius;
		public Vector3 raycastOffset;
		public bool subdivideEveryIter;
		public int iterations;
		public bool useGraphRaycasting;
	}
}
