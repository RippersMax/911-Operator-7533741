using Pathfinding;
using UnityEngine;

public class AIPath : AIBase
{
	public float repathRate;
	public Transform target;
	public bool canSearch;
	public bool canMove;
	public float speed;
	public float rotationSpeed;
	public float slowdownDistance;
	public float pickNextWaypointDist;
	public float endReachedDistance;
	public bool alwaysDrawGizmos;
}
