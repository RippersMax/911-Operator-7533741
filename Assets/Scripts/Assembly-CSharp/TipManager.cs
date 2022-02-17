using Call911.General;
using UnityEngine;
using UnityEngine.UI;

public class TipManager : Singleton<TipManager>
{
	public GameObject loader;
	public GameObject tip;
	public Text loaderText;
	public Text tipTitle;
	public Text tipDesc;
	public Text tipID;
	public Button abortButton;
	public Button closeTipButton;
	public Button nextTipButton;
	public Button prevTipButton;
	public Image tipImage;
	public GameObject[] buttonTab;
}
