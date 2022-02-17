using Call911.Report;

namespace Call911.Behaviour
{
	public class PoliceBehaviourStateOnsite : PoliceBehaviourState
	{
		public PoliceBehaviourStateOnsite(PoliceBehaviourComponent ctrl) : base(default(PoliceBehaviourComponent))
		{
		}

		public ReportBase atReport;
	}
}
