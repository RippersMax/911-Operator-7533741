using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Unitycoding.UIWidgets;

public class TimeLeft : MonoBehaviour
{
	public Text timeLeftText;
	public Text speedText;
	public RectTransform hand;
	public Image clockFill;
	public List<TimeButton> timeButtons;
	[SerializeField]
	private TooltipTrigger timeTooltip;
	public Animator timeAnimator;
}
