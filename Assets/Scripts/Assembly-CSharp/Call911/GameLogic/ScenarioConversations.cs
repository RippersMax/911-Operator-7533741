using System;
using System.Collections.Generic;

namespace Call911.GameLogic
{
	[Serializable]
	public class ScenarioConversations
	{
		public List<string> loadedGenerableConversations;
		public List<string> generableConversations;
		public List<string> generableOnce;
		public float timeToNextCall;
		public int lastCallIDx;
		public string lastGenerated;
		public List<string> generatedOnceCalls;
		public bool useHardcodedCalls;
	}
}
