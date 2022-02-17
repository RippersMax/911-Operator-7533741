using System;

namespace Call911.GameLogic
{
	[Serializable]
	public class InfrastructureInst : GameLogicObject
	{
		public double lat;
		public double lon;
		public InfrastructureType ofType;
	}
}
