using Call911.General;
using Call911.Police;
using UnityEngine;
using Call911.Report;

namespace Call911.Behaviour
{
	public class PoliceBehaviourComponent : BaseComponent<BaseLivingThing>
	{
		public PoliceBase policeBase;
		[SerializeField]
		private PoliceBehaviourState behaviourState;
		public ReportBase targetReport;
	}
}
