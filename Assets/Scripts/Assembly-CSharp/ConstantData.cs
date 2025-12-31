using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConstantData : Singleton<ConstantData>
{
	public enum ScreenToOpen
	{
		SettingScreen = 0,
		MoreApps = 1,
		WhyItsFree = 2,
		OurStoryHelp = 3,
		SelectLangugage = 4,
		OtherScreen = 5,
		ShopScreen = 6,
		certificate = 7,
		certificateFullScreen = 8,
		worksheet = 9,
		HomeYoutube = 10,
		Home = 11,
		SelectNumber = 12,
		ShopStore = 13,
		PlayStore = 14,
		ShopStoreBook = 15,
		HomeYoutubeVideo = 16,
		WoodenToyStore = 17,
		AboutUsNativeReview = 18
	}

	[CompilerGenerated]
	private sealed class _003CPostUserFeedback_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string feedback;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPostUserFeedback_003Ed__69(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static string NumberGenerationRange;

	public static bool isReportGenerate;

	public static bool isGameplayLocalize;

	public static bool isMoreApps;

	public static bool isLucasRoom;

	public static bool isOurStory;

	public static bool isShopIcon;

	public static bool isYouTubebtn;

	public static bool showNLBhelp;

	[HideInInspector]
	public static bool isfromOurstoryVideo;

	public bool isLucasFriendScreenOpen;

	public static bool isShowModeHint;

	public static bool isMatchModeVisible;

	public static bool isMinMaxModeVisible;

	public static bool isAddPuzzleModeVisible;

	public static bool isAddExamModeVisible;

	public static bool isAddLearningModeVisible;

	public static bool isSubPuzzleModeVisible;

	public static bool isSubExamModeVisible;

	public static bool isSubLearningModeVisible;

	public static bool isSubPracticeModeVisible;

	public static bool isAddPracticeModeVisible;

	public static bool isDoubleDigitAddModeVisible;

	public static bool isDoubleDigitSubModeVisible;

	public static bool isVendingMachineModeVisible;

	public static bool isCrossMathModeVisible;

	public static bool isFishingModeVisible;

	public static bool isFunSnowModeVisible;

	public static bool isFunCarModeVisible;

	public static bool isDualPlayerModeVisible;

	public static bool isAdditUpModeVisible;

	public static bool isSudokuModeVisible;

	public static bool isAddSubUFOModeVisible;

	public static bool isWordProblemAdditionModeVisible;

	public static bool isCarryForwardAdditionModeVisible;

	public static bool isAdditionPyramidModeVisible;

	public static bool isWordProblemsSubtractionModeVisible;

	public static bool isGiftBoxPressed;

	public string PuzzleName;

	public static bool isToyEventLive;

	public static string RATE_US;

	public static int LaunchCount;

	public static bool IsChangeUserCalled;

	public static bool ISNewUserGenerate;

	public static bool isShareKidsPopupOn;

	public static bool isLucasRoomSwitchanimation;

	public static bool _SwitchPositionLucasRoom;

	public static string youTubeURL;

	public static int NativePopupHours;

	public bool isNativeFromAboutUs;

	public static bool IsTrasitionFromBillingMode;

	public static float HintDelay;

	public static bool AboutUsNativeReview_IOS;

	public static ScreenToOpen _ScreenToOpen;

	public DateTime currentDate;

	public static Themes ActiveTheme;

	public static Vector3 ScreenRectSize;

	public static Vector3 SafeAreaSize;

	public static float storageReuiredLucasGarden;

	public static float storageReuiredModeBundle;

	public static string WordProblemModeName;

	public static bool isAmazonStoreSubmission => false;

	public static bool NumberLocalizeHelpDisplayed => false;

	public static bool GetRandomBoolean => false;

	public static string GetDisplayTime => null;

	public static bool IsInspringTextAvailable => false;

	public static bool ISForParentsAvilable => false;

	public static bool IsShortContent => false;

	public static bool IsFullContentOurStory => false;

	public static bool IsToyModuleEnable => false;

	public static bool WoodenToyButtonVisibility => false;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public static float FloatParseHandle(string str)
	{
		return 0f;
	}

	public bool Is5daysForNativePopup()
	{
		return false;
	}

	private DateTime GetCurrentDateTime()
	{
		return default(DateTime);
	}

	private void OnDisable()
	{
	}

	private void OnLoadUser()
	{
	}

	public void postuserfeedback(string feedback, string language)
	{
	}

	[IteratorStateMachine(typeof(_003CPostUserFeedback_003Ed__69))]
	public IEnumerator PostUserFeedback(string feedback, string language)
	{
		return null;
	}

	public bool OnCheckPrefsValue(string PrefsName)
	{
		return false;
	}

	private void CheckToggleStatus()
	{
	}

	public void UpdateToggleStatus(string prefName)
	{
	}

	public bool SaveToggleData(bool Status, string PrefsName, bool SetVar)
	{
		return false;
	}

	public static bool ISRunningLowMemory(float requiredSpace)
	{
		return false;
	}

	public static bool IsHindiLikeLanguage()
	{
		return false;
	}

	public static string GetNumberToStringName(string number)
	{
		return null;
	}
}
