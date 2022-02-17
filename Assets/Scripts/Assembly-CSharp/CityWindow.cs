using UnityEngine;
using UnityEngine.UI;

public class CityWindow : MonoBehaviour
{
	public ScrollRect scrollRect;
	public RectTransform singleCitiesContainer;
	public RectTransform regularCareerCities;
	[SerializeField]
	private RectTransform activeContainer;
	public Button prevButton;
	public Button nextButton;
	public int pageCount;
	public int currentPage;
	public int containerPoz;
	public int width;
	public float decelerationRate;
	public float fastSwipeThresholdTime;
	public int fastSwipeThresholdDistance;
}
