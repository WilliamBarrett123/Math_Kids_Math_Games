using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabClickManager : MonoBehaviour
{
	public static TabClickManager Instance;

	public Button CurrentSelectedTAB;

	public GameObject CurrentSelectedContent;

	public GameObject WhyItsFreeBadgeObj;

	public GameObject FadeKids_Badge;

	public GameObject FadeParents_Badge;

	[SerializeField]
	private List<TabSelection> MainTabBtnSelect;

	private bool IsSoundIntialize;

	[HideInInspector]
	public bool isInstaNotificationOnceShow;

	private int ShowRateUsPopup;

	private int NextDisplayShopCount;

	private int TotalTimeShowShopCount;

	private int RandomShopCount;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void DisplayOtherPopupOnScreen()
	{
	}

	private void CheckForDisplayShopScreenPopup()
	{
	}

	private void ShowShopScreenRandomly()
	{
	}

	private void CheckForShopbadge()
	{
	}

	public void showEnjoyGamePopup()
	{
	}

	private void StarRatingAfterDelay()
	{
	}

	public void displayReviewPopup()
	{
	}

	private void OnEnable()
	{
	}

	public void onShopPanalShow()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLocaleChanged(Locale locale)
	{
	}

	private void showOurMissionPopup()
	{
	}

	private void ManageBadge_Ontabs()
	{
	}

	public void OnTabBtnClick(Button TabBtn)
	{
	}

	private void ManageButtons(Button btnObj)
	{
	}

	public void OnCloseBtnClicked()
	{
	}
}
