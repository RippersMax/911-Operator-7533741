using Call911.General;
using UnityEngine;
using UnityEngine.UI;

public class RadioControllerNew : Singleton<RadioControllerNew>
{
	[SerializeField]
	private AudioSource backgroung;
	public AudioSource rvoice;
	public AudioClip[] chatter;
	public AudioClip[] teamSounds;
	public InputField teamno;
}
