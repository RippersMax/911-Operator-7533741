using UnityEngine;
using UnityEngine.UI;

namespace LocalizationEditor
{
	public class LELocalize : MonoBehaviour
	{
		[SerializeField]
		private Text localizedText;
		[SerializeField]
		private GUIText localizedGUIText;
		[SerializeField]
		private TextMesh localizedTextMesh;
		public string localized_string_key;
		public bool useList;
		public bool UseLEEditorListener;
		public LELocalizeState State;
	}
}
