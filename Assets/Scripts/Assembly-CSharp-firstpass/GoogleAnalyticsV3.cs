using UnityEngine;

public class GoogleAnalyticsV3 : MonoBehaviour
{
	public enum DebugMode
	{
		ERROR = 0,
		WARNING = 1,
		INFO = 2,
		VERBOSE = 3,
	}

	public string androidTrackingCode;
	public string IOSTrackingCode;
	public string otherTrackingCode;
	public string productName;
	public string bundleIdentifier;
	public string bundleVersion;
	public int dispatchPeriod;
	public int sampleFrequency;
	public DebugMode logLevel;
	public bool anonymizeIP;
	public bool UncaughtExceptionReporting;
	public bool sendLaunchEvent;
	public bool dryRun;
	public int sessionTimeout;
}
