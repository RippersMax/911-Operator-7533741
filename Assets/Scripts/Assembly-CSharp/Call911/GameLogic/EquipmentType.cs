using System;

namespace Call911.GameLogic
{
	[Serializable]
	public class EquipmentType : GameLogicObject
	{
		public string id;
		public string name;
		public string description;
		public string type;
		public int damage;
		public float fireSpeed;
		public string bonus;
	}
}
