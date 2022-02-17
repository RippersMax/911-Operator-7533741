using Call911.GameLogic;
using System.Collections.Generic;
using UnityEngine;

public class ConversationElement : ComplexEditorElement
{
	public ConversationElement(Conversation parent, string id)
	{
	}

	public bool isOperator;
	public List<ConversationElement> answers;
	public AudioClip voice;
	public bool played;
	public float chanceToPlay;
	public string bgsound;
	public float x;
	public float y;
}
