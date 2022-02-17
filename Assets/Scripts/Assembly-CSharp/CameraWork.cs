using Call911.General;
using UnityEngine;

public class CameraWork : Singleton<CameraWork>
{
	[SerializeField]
	private bool moveByEdge;
	[SerializeField]
	private float focusMoveSpeed;
	public bool gotoTarget;
	public Vector3 targetPosition;
	public Transform targetTransform;
	public bool ignoreLimits;
	public float unitsScale;
}
