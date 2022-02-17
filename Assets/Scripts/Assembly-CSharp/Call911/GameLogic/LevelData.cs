using System;
using System.Collections.Generic;

namespace Call911.GameLogic
{
	[Serializable]
	public class LevelData
	{
		public string cityId;
		public List<PoliceSquad> squads;
		public List<TeamMember> unassignedPoliceman;
		public List<EquipmentInstance> unassignedEquipent;
		public List<PoliceVehicleInstance> unassignedVehicle;
		public List<InfrastructureInst> infrastructure;
		public int cash;
		public List<TeamMember> recruitablePoliceman;
		public List<string> buyableEquipent;
		public List<string> buyableVehicle;
		public List<InfrastructureType> buyableInfrastructure;
		public List<ReportType> reportTypes;
		public ScenarioConversations scenarioConversations;
		public string scenarioEventid;
		public bool answerCalls;
		public int baseIncome;
		public int endCityAfterDuties;
		public List<string> generatedFaces;
		public int callTimesMin;
		public int callTimesMax;
		public int reportTimesMin;
		public int reportTimesMax;
		public int succeedDutyInRow;
		public float difficulty;
	}
}
