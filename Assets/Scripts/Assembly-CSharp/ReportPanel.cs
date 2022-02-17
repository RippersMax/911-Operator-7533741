using UnityEngine;
using Call911.Report;
using UnityEngine.UI;

public class ReportPanel : MonoBehaviour
{
	public ReportBase related;
	public Text reportNo;
	[SerializeField]
	internal Image reportIcon;
	[SerializeField]
	private Text description;
	[SerializeField]
	internal Text time;
	[SerializeField]
	private Text location;
}
