using System.Collections.Generic;

namespace Call911.GameLogic
{
	public class EventElement : ComplexEditorElement
	{
		public string blockedByID;
		public bool isActive;
		public List<TeamMember> resolvers;
		public float timeToResolve;
		public string typeName;
		public string iconName;
		public string iconOverlayId;
		public string iconText;
		public bool iconBlink;
		public OnSiteElementUI iconObject;
		public string eventTimerID;
	}
}
