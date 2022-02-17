using System.Collections.Generic;

namespace Call911.GameLogic
{
	public class Scenario
	{
		public string cityName;
		public string cityId;
		public bool locked;
		public List<string> conversationsIDs;
		public List<string> unlockedVehicles;
		public List<string> unlockedEquipment;
		public LevelData baseLevelData;
		public LevelData playerLavelData;
		public string quest;
		public City menuUIelement;
	}
}
