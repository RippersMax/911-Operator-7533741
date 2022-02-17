using Call911.General;
using UnityEngine;
using UnityEngine.Audio;

namespace Call911.Managers
{
	public class AudioManager : Singleton<AudioManager>
	{
		public OptionsWindow options;
		public GameObject menuAudio;
		public GameObject[] audioSourceTab;
		public AudioMixer masterMixer;
	}
}
