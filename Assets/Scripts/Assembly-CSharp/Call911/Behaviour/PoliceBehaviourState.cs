using System;

namespace Call911.Behaviour
{
	[Serializable]
	public class PoliceBehaviourState
	{
		public PoliceBehaviourState(PoliceBehaviourComponent controller)
		{
		}

		public float timeToThink;
		public PoliceBehaviourComponent controller;
	}
}
