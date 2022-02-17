using System;
using UnityEngine;

namespace Call911.GameLogic
{
	[Serializable]
	public class ReportType
	{
		public string id;
		public string name;
		public string description;
		public string type;
		public string poi;
		public Sprite iconSprite;
		public int popularity;
		public int bill;
		public int billRange;
		public float prisonChance;
		public float timeToReact;
		public float fightRisk;
		public int criminalsNumber;
		public float crimanlsArmed;
		public float runChance;
		public float onRunAlready;
		public float maxSpeed;
		public float visibility;
		public int opinionEffect;
		public int injuriedHeavy;
		public int injuriedLight;
		public float techwork;
		public int firework;
		public int fireGrowth;
		public int totalReported;
		public int totalResolved;
		public string dlc;
		public int searchWork;
		public int searchArea;
	}
}
