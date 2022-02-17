using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsWindow : MonoBehaviour
{
	public Toggle moveByEdge;
	public Toggle showTutorial;
	public Toggle showTeamText;
	public Toggle muteOperator;
	public Toggle muffleDialogs;
	public Button resetDataButton;
	public Button backButton;
	public Button addLangButton;
	public Button workshopButton;
	public Slider soundSlider;
	public Slider musicSlider;
	public GameObject languageList;
	public AudioMixer masterMixer;
	public Text actualLanguage;
}
