using Call911.General;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleManager : Singleton<ConsoleManager>
{
	public Transform consolePanel;
	public Button submitButton;
	public InputField inputField;
	public Text message;
	public GameObject alert;
	public Transform slotVehicle;
	public string lastCmd;
}
