using Call911.General;
using UnityEngine.UI;
using UnityEngine;

public class TutorialManager : Singleton<TutorialManager>
{
	public enum TUTORIAL_PHASE
	{
		START = 0,
		INFO_1 = 1,
		INFO_2 = 2,
		SELECT = 3,
		SEND = 4,
		INFO_GO = 5,
		BASES = 6,
		DEPLOY = 7,
		WAIT = 8,
		REPORT = 9,
		ADDRESS = 10,
		SENDUNIT = 11,
		SENTWRONG = 12,
		SENTOK = 13,
		SHOWONSITE = 14,
		SHOWONSITE2 = 15,
		CALL = 16,
		CONVERSATION = 17,
		DECISION = 18,
		CARRYON = 19,
		OFF = 20,
		SURESKIP = 21,
		PREPARE = 22,
		START_SEARCH = 23,
		SELECT_UNIT_TO_SEARCH = 24,
		SEND_UNIT_TO_SEARCH = 25,
		STAY = 26,
		CLEAR = 27,
		FOUND = 28,
		REMINDER = 29,
		SEND_UNIT_TO_MARKER = 30,
		AUTO_SEARCH = 31,
		MANUAL_SEARCH = 32,
		NOTFOUND = 33,
	}

	public TUTORIAL_PHASE state;
	[SerializeField]
	private Button buttonOK;
	[SerializeField]
	private Button buttonSKIP;
	[SerializeField]
	private Text text;
}
