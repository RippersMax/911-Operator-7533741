using System;
using UnityEngine;

namespace Call911.GameLogic
{
	[Serializable]
	public class PoliceVehicleType : GameLogicObject
	{
		public string id;
		public string name;
		public string description;
		public string icon;
		public string type;
		public float visibility;
		public float armour;
		public float maxSpeed;
		public float acceleration;
		public int maxInTeam;
		public string terrain;
		public int teammembersSeats;
		public int criminalsSeats;
		public int placesInjuried;
		public bool patrols;
		public string bonus;
		public Color color;
		public int upkeep;
	}
}
