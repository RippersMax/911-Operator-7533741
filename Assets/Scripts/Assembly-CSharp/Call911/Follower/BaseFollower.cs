using Call911.General;
using UnityEngine;

namespace Call911.Follower
{
	public class BaseFollower : BaseComponent<BaseLivingThing>
	{
		[SerializeField]
		public float maxSpeed;
		public float acceleration;
		public float speed;
		[SerializeField]
		private float reachDistance;
		public Vector3 target;
		public GroundFollower followedObject;
		public RoadScript pathObject;
	}
}
