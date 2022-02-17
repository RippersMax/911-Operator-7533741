using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Audio;

public class TalkDetailsPanel : DetailsPanel
{
	[SerializeField]
	private Transform options;
	[SerializeField]
	private Transform reminderText;
	public ScrollRect scrollArea;
	public AudioClip background;
	public AudioSource QuoteAudioSource;
	public List<AudioMixerSnapshot> mumbleSnaps;
	public AudioMixerSnapshot clearSnap;
	public bool countTime;
	public Text convText;
	[SerializeField]
	private RectTransform optionsRectTransform;
	[SerializeField]
	private GameObject optionsScrollbar;
}
