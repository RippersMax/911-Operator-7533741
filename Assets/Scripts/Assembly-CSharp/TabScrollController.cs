using UnityEngine;
using UnityEngine.UI;

public class TabScrollController : MonoBehaviour
{
	public RectTransform container;
	public RectTransform headerPanel;
	public RectTransform thisWindow;
	public GameObject scrollbar;
	public Button clicker;
	public bool hidden;
	public bool coroutineRunning;
}
