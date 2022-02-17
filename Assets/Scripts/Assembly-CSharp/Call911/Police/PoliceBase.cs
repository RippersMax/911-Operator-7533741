using Call911.General;
using Call911.GameLogic;
using Call911.Behaviour;
using UnityEngine;

namespace Call911.Police
{
	public class PoliceBase : BaseLivingThing
	{
		public PoliceSquad squad;
		public new PoliceBehaviourComponent behaviour;
		public string atPlaceName;
		public Transform pinTag;
		public bool inSearchArea;
	}
}
