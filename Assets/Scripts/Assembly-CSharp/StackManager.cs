using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class StackManager : Singleton<StackManager>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGoForReview_WSA_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private GameObject CharacterIntro;

	public Stack<GameObject> GameWindowStack;

	public PrespawedScreen[] prespawedScreens;

	public bool IsCloseUsingSlider;

	public GameObject canvas;

	private bool isInToastMode;

	public bool isCommonPopup;

	[HideInInspector]
	public bool isBackFromGamePlay;

	public bool isConnectionErrorPopup;

	public static event Action<bool, string> OnScreenStatusUpdatedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void CommonPopUp(bool isFromReportPopup = false)
	{
	}

	public bool isPackageInstalled(string packageName)
	{
		return false;
	}

	public void ConnectionError()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void OnBackButtonPressedEvent()
	{
	}

	public GameObject PopScreeen()
	{
		return null;
	}

	public void OpenRateUS()
	{
	}

	public void OpenRateUsMac()
	{
	}

	[AsyncStateMachine(typeof(_003CGoForReview_WSA_003Ed__22))]
	private void GoForReview_WSA()
	{
	}

	public GameObject PeekScreen()
	{
		return null;
	}

	public string GetPeekScreenName()
	{
		return null;
	}

	public void PushScreen(GameObject PushObject)
	{
	}

	public GameObject SpawnUIScreen(string _screenName, bool doRequireLoading = false)
	{
		return null;
	}

	public GameObject SpawnUIScreen(string _screenName, bool doRequireLoading, float loadTime)
	{
		return null;
	}

	public GameObject SpawnPrefabFromResources(string path, bool SpawnIfDuplicate = false)
	{
		return null;
	}

	public void OnBackButtonPressed(bool ignoreTouch = false)
	{
	}

	private void showCertificateInstaPopup()
	{
	}

	public void EventFireForScreenChange()
	{
	}

	private void LoadMainMenuFromGameplay()
	{
	}

	private void ShowExitToast()
	{
	}

	private void DisableExitToast()
	{
	}

	public void ShowReportTranslationToast(bool isNetworkError = false)
	{
	}

	private void DisableReportTranslationToast()
	{
	}
}
