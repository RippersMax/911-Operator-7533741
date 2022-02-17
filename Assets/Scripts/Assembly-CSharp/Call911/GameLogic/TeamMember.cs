using System;

namespace Call911.GameLogic
{
	[Serializable]
	public class TeamMember : GameLogicObject
	{
		public EquipmentInstance equipment1;
		public EquipmentInstance equipment2;
		public float experience;
		public float drivingSkill;
		public int salary;
		public Fighter fighter;
		public string type;
		public float firstaid;
		public float skill;
	}
}
