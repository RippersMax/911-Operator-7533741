using Call911.General;
using UnityEngine;
using UnityEngine.UI;

namespace Call911.Managers
{
	public class GUIMenuManager : Singleton<GUIMenuManager>
	{
		[SerializeField]
		public Transform citiesList;
		public Button careerButton;
		public Button freeGameButton;
		public Button continueButton;
		public Button creditsButton;
		public Button facebookBtn;
		public GameObject careerWindow;
		public GameObject freeGameWindow;
		public GameObject backgroundWindow;
		public GameObject creditsWindow;
		public GameObject careerModeWindow;
		public GameObject difficultyWindow;
		public Text continueButtonText;
		public CityWindow cityWindow;
		public OptionsWindow options;
		public ScrollRect creditsContainer;
		[SerializeField]
		private Button[] difficultyButtons;
		[SerializeField]
		private Button[] careerModeButtons;
		public GameObject banner;
		[SerializeField]
		private GameObject dlcNotification;
	}
}
