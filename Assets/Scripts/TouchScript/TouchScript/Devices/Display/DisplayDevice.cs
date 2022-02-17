using UnityEngine;

namespace TouchScript.Devices.Display
{
	public class DisplayDevice : ScriptableObject
	{
		[SerializeField]
		protected new string name;
		[SerializeField]
		protected float dpi;
	}
}
