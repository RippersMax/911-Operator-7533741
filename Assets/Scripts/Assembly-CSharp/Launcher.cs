using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
	[SerializeField]
	private Text title;
	[SerializeField]
	private Toggle neverShowAgain;
	[SerializeField]
	private Button skipButton;
	[SerializeField]
	private Text skipButtonText;
	[SerializeField]
	private Transform appContainer;
	[SerializeField]
	private ScrollRect scrollRect;
	[SerializeField]
	private Image loadingCircle;
	[SerializeField]
	private GameObject appBanerPrefab;
}
