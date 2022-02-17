using System;
using System.Collections.Generic;
using UnityEngine;

namespace Call911.GameLogic
{
	[Serializable]
	public class Squad
	{
		public enum SquadType
		{
			POLICE = 0,
			MEDICAL = 1,
			FIRE = 2,
		}

		public int squadNo;
		public string code;
		public List<PoliceVehicleInstance> vehicles;
		public List<TeamMember> members;
		public Vector2 assignedToPlace;
	}
}
