using UnityEngine;

namespace Pathfinding
{
	public class GraphUpdateScene : GraphModifier
	{
		public Vector3[] points;
		public bool convex;
		public float minBoundsHeight;
		public int penaltyDelta;
		public bool modifyWalkability;
		public bool setWalkability;
		public bool applyOnStart;
		public bool applyOnScan;
		public bool updatePhysics;
		public bool resetPenaltyOnPhysics;
		public bool updateErosion;
		public bool modifyTag;
		public int setTag;
		public bool legacyMode;
		[SerializeField]
		private int serializedVersion;
		[SerializeField]
		private bool legacyUseWorldSpace;
	}
}
