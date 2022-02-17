using Call911.General;
using UnityEngine.UI;
using UnityEngine;

namespace Call911.GUI
{
	public class UnitsTab : Singleton<UnitsTab>
	{
		public Button reinforcementButton;
		public GameObject activeTab;
		public GameObject unitTab;
		public GameObject reinforcementsTab;
		public string linkedReinforcementID;
		public bool waitingForReinforcement;
	}
}
