using System;
using Call911.Managers;

namespace Call911.GameLogic
{
	[Serializable]
	public class ReportInstance
	{
		public enum ResolveType
		{
			IGNORED = 0,
			TIMEOUT = 1,
			NOREACTION = 2,
			LOST = 3,
			RESOLVED = 4,
			NONEYET = 5,
		}

		public ReportType ofType;
		public double lat;
		public double lon;
		public string address;
		public float timeLeftToReact;
		public float timeToStop;
		public string afterActionReport;
		public float finalOpinion;
		public float onIgnoreOpinion;
		public bool onIgnoreOpinionSet;
		public ResolveType wayResolved;
		public ReportWindow reportWindow;
	}
}
