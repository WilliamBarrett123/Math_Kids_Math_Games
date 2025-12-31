using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : Singleton<SettingsScreen>
{
	public Toggle MusicBtn;

	public Toggle SoundBtn;

	public Toggle GenerateReport;

	public Toggle ShowCharacterIntroatStart;

	public Toggle ShowHintToggle;

	public Toggle MatchObjectCountingToggle;

	public Toggle GameplayLocalize;

	public Text levelText1;

	public Text levelText2;

	public Text levelText3;

	public Text levelText4;

	private bool rateClicked;

	private bool IsInitalize;

	public GameObject NumberSelectionPanel;

	public string LastLearnWithSelected;

	private GameObject MultiUserBtn;

	private Vector3 thumbAnimStart;

	private Vector3 thumbAnimEnd;

	private List<string> lstFollowLink;

	[SerializeField]
	private Text textSelectLangTitle;

	[SerializeField]
	private Text textCurrentLang;

	[SerializeField]
	private Text textSelectLangTitleOther;

	[SerializeField]
	private GameObject LanguageContainer;

	private string systemLanguage;

	[SerializeField]
	private GameObject OurStoryContainer;

	[SerializeField]
	private GameObject ShopIconContainer;

	private string[] HolderNum;

	private string url;

	[SerializeField]
	private GameObject Mother;

	[SerializeField]
	private GameObject Father;

	[SerializeField]
	private GameObject OptionsPanel;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void EnableISIntitalize()
	{
	}

	private void CheckCurrentStudentName()
	{
	}

	private void ResetAllToggleBtnOnLaunch()
	{
	}

	private void OnEnable()
	{
	}

	public void OnLocaleChanged(Locale locale)
	{
	}

	private void changeNumberLocalization()
	{
	}

	private void SetLanguageTexts()
	{
	}

	private void callFollowFunction()
	{
	}

	private void RateUsThumbAnim()
	{
	}

	private void OnUserChange(string obj, bool CanPlayBG)
	{
	}

	private void OnDisable()
	{
	}

	private void OnScreenStatusUpdatedEvent(bool IsTrue, string screenName)
	{
	}

	private void OnEditUserDetails(string newName, string Oldname)
	{
	}

	private void OnLoadUser()
	{
	}

	private void setBottmBannerTextSize()
	{
	}

	private void setLeveltextLocally()
	{
	}

	public void CheckMusicIsOn(Toggle Status)
	{
	}

	public void CheckMatchObjectCountingIsOn(Toggle Status)
	{
	}

	public void CheckShowHintIsOn(Toggle Status)
	{
	}

	public void CheckSoundIsOn(Toggle Status)
	{
	}

	public void ShowCharacterIntroatStartisON(Toggle Status)
	{
	}

	public void OnSelectlanguageBtn()
	{
	}

	public void OnVisibleButtonPressed()
	{
	}

	public void OnStudentBtnPressed()
	{
	}

	public void onReportTranslationError()
	{
	}

	public void OnViewReportCardPressed()
	{
	}

	public void OnCloseButtonPressed()
	{
	}

	public void IsReportGenerate(Toggle Status)
	{
	}

	public void OnWhyItsFreeButtonPressed()
	{
	}

	public void OnRateButtonPressed(Transform btn)
	{
	}

	private void showRateUsNewPopup()
	{
	}

	public void changeRateUsButtonText()
	{
	}

	public void OnVideoButtonPressed(Transform Thisbtn)
	{
	}

	public void OnMoreAppsButtonClick()
	{
	}

	public void OnLearnWithSelectionNumber(string NumberCategories)
	{
	}

	private void WhyItsFReeButtonAnimationDisable()
	{
	}

	private void enableRateClick()
	{
	}

	public void DisableEnableAlertSign()
	{
	}

	private void CountLaunchOfSettingscreen()
	{
	}

	private void shareKidsEducationPopup()
	{
	}

	public void OnShareBtn(string ShareAppName)
	{
	}

	public void onQuickFactsShareBtn(string ShareAppName)
	{
	}

	public void OnFollowUsBtnClicked(GameObject thisGameObject)
	{
	}

	private void openURL()
	{
	}

	public void spawnGrownUPScreenModifyPopUp()
	{
	}

	public void spawnHideMainScreenButtonPopUp()
	{
	}

	public void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}
}
