using Call911.General;
using System.Collections.Generic;

namespace Call911.Assets
{
	public class PrefabsDatabase : Singleton<PrefabsDatabase>
	{
		public PrefabsPool Pool;
		public List<PrefabsSet> PrefabsSources;
	}
}
