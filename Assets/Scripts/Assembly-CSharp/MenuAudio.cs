using Call911.General;
using UnityEngine;
using System.Collections.Generic;

public class MenuAudio : Singleton<MenuAudio>
{
	public AudioSource managementAudioSource;
	public AudioClip sarManagement;
	public List<AudioClip> managementClips;
}
