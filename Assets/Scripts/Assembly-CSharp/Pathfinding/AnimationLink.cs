using System;
using UnityEngine;

namespace Pathfinding
{
	public class AnimationLink : NodeLink2
	{
		[Serializable]
		public class LinkClip
		{
			public AnimationClip clip;
			public Vector3 velocity;
			public int loopCount;
		}

		public string clip;
		public float animSpeed;
		public bool reverseAnim;
		public GameObject referenceMesh;
		public LinkClip[] sequence;
		public string boneRoot;
	}
}
