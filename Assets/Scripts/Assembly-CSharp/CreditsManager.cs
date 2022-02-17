using Call911.General;
using UnityEngine;
using UnityEngine.UI;

public class CreditsManager : Singleton<CreditsManager>
{
	[SerializeField]
	private AudioSource audioSource;
	[SerializeField]
	private Animator chapterAnimator;
	[SerializeField]
	private Text title;
	[SerializeField]
	private Text subtitle;
	[SerializeField]
	private GameObject creditsCanvas;
	[SerializeField]
	private MovieTexture movieTexture;
	[SerializeField]
	private RawImage rawImage;
}
