using UnityEngine;
using Call911.Map;

public class CityData : MonoBehaviour
{
	[SerializeField]
	public MapBase map;
	public double xmin;
	public double ymin;
	public double xmax;
	public double ymax;
	public double lonFactor;
	public double latFactor;
	[SerializeField]
	private SpriteRenderer bigBcg;
}
