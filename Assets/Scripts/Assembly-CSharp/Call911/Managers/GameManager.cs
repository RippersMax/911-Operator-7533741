using Call911.General;
using UnityEngine;
using System.Collections.Generic;
using Call911.Police;
using Call911.Report;
using Call911.GameLogic;
using Call911.Map;
using UnityEngine.UI;

namespace Call911.Managers
{
	public class GameManager : Singleton<GameManager>
	{
		public float timeLeft;
		[SerializeField]
		private float timeSpeed;
		public bool dutyMode;
		public bool deploymentMode;
		public List<PoliceBase> policeList;
		public List<ObjectBase> infastructureList;
		public List<ReportBase> reportList;
		public List<ReportInstance> queuedReportsList;
		public PoliceBase SelectedPoliceTeam;
		public ReportInstance DisplayedReport;
		public bool allDisplayed;
		public ReportBase activeSearchRep;
		public InfoPanel infoPanel;
		[SerializeField]
		private MapBase map;
		public LevelData levelData;
		public CityData cityData;
		[SerializeField]
		private float overtimeValue;
		[SerializeField]
		public Canvas dutyUI;
		public TopPanel topPanel;
		public ManagmentManager managementUI;
		public NewCallInd newCallButton;
		public RectTransform newReportPanel;
		[SerializeField]
		public Button finishDeployment;
		[SerializeField]
		public DutySummary dutySummary;
	}
}
