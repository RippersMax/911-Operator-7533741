using Call911.General;
using System.Collections.Generic;
using Steamworks;

public class WorkShopTest : Singleton<WorkShopTest>
{
	public List<PublishedFileId_t> subscribedItemList;
	public List<string> itemsPaths;
	public List<string> languageFiles;
	public List<string> callFiles;
	public List<string> mapFiles;
	public List<string> scenarioFiles;
	public List<CSteamID> adminList;
}
