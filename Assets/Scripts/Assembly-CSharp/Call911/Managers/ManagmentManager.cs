using Call911.General;
using UnityEngine;
using UnityEngine.UI;

namespace Call911.Managers
{
	public class ManagmentManager : Singleton<ManagmentManager>
	{
		public Transform SquadsGrid;
		public Transform VehiclesGrid;
		public GameObject SquadList;
		public Transform Canvas;
		public Transform EquipmentGrid;
		public Transform EquipmentShop;
		public Transform VehicleShop;
		public Transform PolicemanShop;
		public Transform PolicemanGrid;
		public GameObject ShopPanel;
		public GameObject EquipmentShopPanel;
		public GameObject PolicemanRec;
		public GameObject VehiclePanel;
		public GameObject PolicemanPanel;
		public GameObject EquipmentPanel;
		public GameObject InfraPanel;
		public Transform InfastructureShop;
		public Transform InfraGrid;
		public Transform AllShopsPanel;
		public Transform AllResources;
		public Transform UIRootAssignment;
		public GameObject CashButtonObj;
		public Text cityName;
		[SerializeField]
		private Text economyButtonText;
	}
}
