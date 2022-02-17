using UnityEngine;

namespace Pathfinding
{
	public class ABPath : Path
	{
		public Vector3 originalStartPoint;
		public Vector3 originalEndPoint;
		public Vector3 startPoint;
		public Vector3 endPoint;
		public bool calculatePartial;
	}
}
