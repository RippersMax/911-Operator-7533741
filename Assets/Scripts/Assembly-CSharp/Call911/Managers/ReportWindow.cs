using UnityEngine;
using UnityEngine.UI;
using Call911.GameLogic;

namespace Call911.Managers
{
	public class ReportWindow : MonoBehaviour
	{
		public Button btTabInfo;
		public Button btTabDialog;
		public Button btTabOnSite;
		public ReportDetailsPanel reportDetailsPanel;
		public TalkDetailsPanel talkDetailsPanel;
		public OnSiteDetailsPanel onSiteDetailsPanel;
		public AddressPanel addressPanel;
		public Button btIgnore;
		public Button btCallAll;
		public Button btWait;
		public Button btClose;
		public ReportInstance reportInstance;
	}
}
