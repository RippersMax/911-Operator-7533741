using UnityEngine;
using Call911.Police;
using UnityEngine.UI;

namespace Call911.GUI
{
	public class UnitPanel : MonoBehaviour
	{
		[SerializeField]
		private PoliceBase related;
		[SerializeField]
		private Text no;
		[SerializeField]
		private Text unit;
		[SerializeField]
		private Image unitIcon;
		[SerializeField]
		private Image unitBcg;
		[SerializeField]
		private Text status;
		[SerializeField]
		private Image statusIcon;
		[SerializeField]
		private Text members;
		[SerializeField]
		private Text places;
		[SerializeField]
		private Text location;
		[SerializeField]
		private Text cost;
		public GameObject inactiveImage;
	}
}
