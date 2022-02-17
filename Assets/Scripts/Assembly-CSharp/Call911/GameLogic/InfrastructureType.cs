using System;

namespace Call911.GameLogic
{
	[Serializable]
	public class InfrastructureType : GameLogicObject
	{
		public string name;
		public string description;
		public string homeFor;
		public double lat;
		public double lon;
		public string type;
	}
}
