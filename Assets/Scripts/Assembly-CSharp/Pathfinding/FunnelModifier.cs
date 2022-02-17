using System;

namespace Pathfinding
{
	[Serializable]
	public class FunnelModifier : MonoModifier
	{
		public bool unwrap;
		public bool splitAtEveryPortal;
	}
}
