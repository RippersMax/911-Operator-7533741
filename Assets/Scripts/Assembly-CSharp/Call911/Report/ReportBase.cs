using Call911.General;
using Call911.Behaviour;
using Call911.GameLogic;
using System.Collections.Generic;
using Call911.Police;
using UnityEngine;

namespace Call911.Report
{
	public class ReportBase : BaseLivingThing
	{
		public new ReportBehaviourComponent behaviour;
		public ReportInstance reportInstance;
		public List<PoliceBase> assignedTeams;
		public bool hided;
		public RectTransform searchAreaPanel;
	}
}
