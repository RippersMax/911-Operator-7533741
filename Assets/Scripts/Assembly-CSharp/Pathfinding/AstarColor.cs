using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public class AstarColor
	{
		public Color _NodeConnection;
		public Color _UnwalkableNode;
		public Color _BoundsHandles;
		public Color _ConnectionLowLerp;
		public Color _ConnectionHighLerp;
		public Color _MeshEdgeColor;
		public Color[] _AreaColors;
	}
}
