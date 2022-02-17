using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour
{
	public string cityName;
	public string cityId;
	[SerializeField]
	private Button startButton;
	[SerializeField]
	private Button backButton;
	[SerializeField]
	private Button unlockButton;
	[SerializeField]
	private Button resetButton;
	public Image lockedImage;
	public Image background;
	public Text description;
	public new Text name;
	[SerializeField]
	private Sprite emptyBackground;
}
