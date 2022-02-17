namespace Call911.GameLogic
{
	public class EventCriminal : EventPerson
	{
		public enum CRIMINAL_TYPE
		{
			TYPE_PRISON = 0,
			TYPE_BILL = 1,
			TYPE_NONE = 2,
		}

		public enum CRIMINAL_STATES
		{
			STATE_FIGHTING = 0,
			STATE_FREE = 1,
			STATE_HIDDEN = 2,
			STATE_RESOLVING = 3,
			STATE_INCHAINS = 4,
			STATE_RESOLVED = 5,
		}

		public float timeToThink;
		public float fightRisk;
		public int bill;
		public CRIMINAL_TYPE resolveType;
		public CRIMINAL_STATES state;
	}
}
