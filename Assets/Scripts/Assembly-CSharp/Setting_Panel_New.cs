using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Setting_Panel_New : MonoBehaviour
{
	public enum ScreenList
	{
		Home = 0,
		Settings = 1,
		LucasFriends = 2,
		ParentApps = 3,
		Worksheets = 4
	}

	[Serializable]
	private class scrrenWisePanel
	{
		public string ScreenName;

		public List<GameObject> lstCurrentPanel;
	}

	[CompilerGenerated]
	private sealed class _003CShowNativeReviewAfterDelay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

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
		public _003CShowNativeReviewAfterDelay_003Ed__21(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CshowRateUsAutoLaunch_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

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
		public _003CshowRateUsAutoLaunch_003Ed__20(int _003C_003E1__state)
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

	public static Setting_Panel_New Instance;

	[HideInInspector]
	public ScreenList currentActiveScreen;

	[SerializeField]
	private List<scrrenWisePanel> lstScreenViseObject;

	[SerializeField]
	private Transform ClickRingAnimation;

	[SerializeField]
	private Transform NotchBackground;

	[SerializeField]
	private Transform iPadBackground;

	[SerializeField]
	private Transform MainSelectionPanel;

	[SerializeField]
	private AudioClip topPanelClick;

	private Camera mainCamera;

	private int ShowRateUsPopup;

	private int NextDisplayShopCount;

	private int TotalTimeShowShopCount;

	private int RandomShopCount;

	[SerializeField]
	private GameObject Ad_icon;

	private Vector3 currPos;

	private Transform ParticleObj;

	private bool isRequestedForDownloadBanner;

	private bool AllowInput;

	private bool isDefaultOpen;

	[SerializeField]
	private GameObject HomeContent;

	[SerializeField]
	private GameObject SettingContent;

	[SerializeField]
	private GameObject ParentContent;

	[SerializeField]
	private GameObject WorkSheetContent;

	[SerializeField]
	private Transform ButtonHome;

	[SerializeField]
	private Transform ButtonSetting;

	[SerializeField]
	private Transform ButtonParent;

	[SerializeField]
	private Transform ButttonWorksheet;

	[SerializeField]
	private Transform Father;

	[SerializeField]
	private Transform Mother;

	private void Awake()
	{
	}

	public void selectDisplayTab(ScreenList name = ScreenList.Home)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void CheckReviewConditions()
	{
	}

	[IteratorStateMachine(typeof(_003CshowRateUsAutoLaunch_003Ed__20))]
	private IEnumerator showRateUsAutoLaunch(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowNativeReviewAfterDelay_003Ed__21))]
	public IEnumerator ShowNativeReviewAfterDelay(float delay = 0f)
	{
		return null;
	}

	public void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	public void BtnClickRingParticle()
	{
	}

	private void TopPanelHightLightAnimation(Transform MainObject, bool isOpen, bool isDefault)
	{
	}

	private Color PanelColorCode(string name)
	{
		return default(Color);
	}

	private Color ClickRingColorCode(ScreenList name)
	{
		return default(Color);
	}

	public void OpenCloseTabSelectionDetails(ScreenList currentScreen, bool isOpen, bool isDefault)
	{
	}

	public void onButtonClickSoundForSetting()
	{
	}

	public void TapOnTopObjectToScreenChanges(Transform thisTransform)
	{
	}

	public void onCloseButtonPressed(GameObject thisGameObject)
	{
	}

	private void Close()
	{
	}

	public void RequestForDownloadBannerBundle()
	{
	}

	private void OnBannerBundleDownloadStatus(bool isresult)
	{
	}

	public void DeviceBackCall()
	{
	}

	public void HeaderButtonClick(Transform transform)
	{
	}

	private void AdjustBottomPanelContent(Transform transform)
	{
	}

	private void AdjustTopPanel(Transform transform)
	{
	}

	private void FatherMotherPosUpdate()
	{
	}

	private void Reset()
	{
	}

	public void ScaleAnimation(Transform thisTransform, Action<bool> callback = null)
	{
	}
}
