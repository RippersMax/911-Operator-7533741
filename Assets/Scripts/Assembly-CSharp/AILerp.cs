using Pathfinding;
using UnityEngine;

public class AILerp : VersionedMonoBehaviour
{
	public float repathRate;
	public Transform target;
	public bool canSearch;
	public bool canMove;
	public float speed;
	public bool enableRotation;
	public bool rotationIn2D;
	public float rotationSpeed;
	public bool interpolatePathSwitches;
	public float switchPathInterpolationSpeed;
}
