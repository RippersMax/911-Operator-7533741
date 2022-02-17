using Pathfinding;
using UnityEngine;

public class AstarPath : VersionedMonoBehaviour
{
	private AstarPath()
	{
	}

	public AstarData data;
	public bool showNavGraphs;
	public bool showUnwalkableNodes;
	public GraphDebugMode debugMode;
	public float debugFloor;
	public float debugRoof;
	public bool manualDebugFloorRoof;
	public bool showSearchTree;
	public float unwalkableNodeDebugSize;
	public PathLog logPathResults;
	public float maxNearestNodeDistance;
	public bool scanOnStartup;
	public bool fullGetNearestSearch;
	public bool prioritizeGraphs;
	public float prioritizeGraphsLimit;
	public AstarColor colorSettings;
	[SerializeField]
	protected string[] tagNames;
	public Heuristic heuristic;
	public float heuristicScale;
	public ThreadCount threadCount;
	public float maxFrameTime;
	public int minAreaSize;
	public bool batchGraphUpdates;
	public float graphUpdateBatchingInterval;
	public EuclideanEmbedding euclideanEmbedding;
	public bool showGraphs;
}
