using System;

namespace Pathfinding
{
	[Serializable]
	public class SimpleSmoothModifier : MonoModifier
	{
		public enum SmoothType
		{
			Simple = 0,
			Bezier = 1,
			OffsetSimple = 2,
			CurvedNonuniform = 3,
		}

		public SmoothType smoothType;
		public int subdivisions;
		public int iterations;
		public float strength;
		public bool uniformLength;
		public float maxSegmentLength;
		public float bezierTangentLength;
		public float offset;
		public float factor;
	}
}
