using Call911.General;
using System.Collections.Generic;

public class MapDownloader : Singleton<MapDownloader>
{
	public bool isRunning;
	public bool downloadingCampaign;
	public List<string> finishedCoroutines;
	public bool updateByOSM;
}
