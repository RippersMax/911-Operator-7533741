using Call911.General;
using UnityEngine;
using UnityEngine.UI;
using Call911.GameLogic;

namespace Call911.Police
{
	public class PoliceVisual : BaseComponent<PoliceBase>
	{
		[SerializeField]
		private Transform highlight;
		[SerializeField]
		private Text textFeed;
		[SerializeField]
		private Transform textFeedCloud;
		[SerializeField]
		private ParticleSystem syrene;
		public Image icon;
		public Image pin;
		public Color redSyrene;
		public Color blueSyrene;
		public Transform statusObj;
		public Image statusIcon;
		public Squad.SquadType squadType;
		[SerializeField]
		public Transform seatsTransform;
	}
}
