using System.Collections.Generic;

namespace Call911.GameLogic
{
	public class ScenarioEvent
	{
		public List<int> duties;
		public float toStart;
		public bool warningBeforeStart;
		public string[] eventsTypes;
		public List<PoliceSquad> supportSquads;
	}
}
