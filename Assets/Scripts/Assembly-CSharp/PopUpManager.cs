using Call911.General;
using UnityEngine;
using UnityEngine.UI;

public class PopUpManager : Singleton<PopUpManager>
{
	public GameObject popUp;
	public GameObject alertPanel;
	public GameObject slot;
	public Text popUpText;
	public GameObject citiesListView;
	public Button confirmButton;
	public Button cancelButton;
	public Transform citiesContainer;
	public bool showSaleWindow;
}
