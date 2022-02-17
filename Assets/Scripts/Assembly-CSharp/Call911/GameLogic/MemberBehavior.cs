using System;

namespace Call911.GameLogic
{
	[Serializable]
	public class MemberBehavior
	{
		public enum MemberState
		{
			WAITING = 0,
			FIGHTING = 1,
			WORKING = 2,
			INJURIED = 3,
			DEAD = 4,
		}

		public TeamMember member;
		public MemberState state;
		public float timeToThink;
	}
}
