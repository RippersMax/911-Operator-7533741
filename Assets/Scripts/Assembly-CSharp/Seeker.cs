using Pathfinding;
using UnityEngine;

public class Seeker : VersionedMonoBehaviour
{
	public bool drawGizmos;
	public bool detailedGizmos;
	public StartEndModifier startEndModifier;
	public int traversableTags;
	[SerializeField]
	protected TagMask traversableTagsCompatibility;
	public int[] tagPenalties;
}
