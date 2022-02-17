using System;

namespace Pathfinding
{
	[Serializable]
	public class AlternativePath : MonoModifier
	{
		public int penalty;
		public int randomStep;
	}
}
