using UnityEngine;

namespace Pathfinding
{
	public class AstarDebugger : VersionedMonoBehaviour
	{
		public int yOffset;
		public bool show;
		public bool showInEditor;
		public bool showFPS;
		public bool showPathProfile;
		public bool showMemProfile;
		public bool showGraph;
		public int graphBufferSize;
		public Font font;
		public int fontSize;
	}
}
