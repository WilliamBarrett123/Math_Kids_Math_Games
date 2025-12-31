using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameUIController : Singleton<GameUIController>
{
	[CompilerGenerated]
	private sealed class _003COpenURL_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string URL;

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
		public _003COpenURL_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CSpawEpisodScreen_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CSpawEpisodScreen_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CSpawJigsawmode_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CSpawJigsawmode_003Ed__33(int _003C_003E1__state)
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

	public Canvas UICanvas;

	public GameObject LoadingLeaves;

	public GameObject ExitToast;

	public GameObject ReportTranslationToast;

	public GameObject ChangeUserSuccessPopup;

	public GameObject MainMenu;

	public bool isPracticeAddition;

	public string PracticeGameModeName;

	public bool isGoodJobScreenPresent;

	public bool isCloseOurstoryScreen;

	public static bool isNotchDevice;

	public float NotchDifference;

	public bool BothSideNotch;

	public bool isGamePlayMusicPlaying;

	private static string _PersistentPath;

	public string ShopUrlToRedirect;

	public static bool NewOurStoryScreenAlternate;

	public static string PersistentPath => null;

	public static bool isSpeechAvailable => false;

	public bool TallScreenSize => false;

	public bool ExtraTallScreenSize => false;

	public static bool IsOurstoryVideoEnable => false;

	public static bool IsMainScreenOurstoryEnable => false;

	public static bool IsMessageForAdultsEnable => false;

	public static event Action GameplayLocalization
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

	public void gameplayLocalizationtrigger()
	{
	}

	public void GameplayLionPositionSet()
	{
	}

	public void ShowLeaves()
	{
	}

	public void EnableMainMenu()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawEpisodScreen_003Ed__32))]
	public IEnumerator SpawEpisodScreen()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSpawJigsawmode_003Ed__33))]
	public IEnumerator SpawJigsawmode()
	{
		return null;
	}

	public void DisableMainMenu()
	{
	}

	public void Object_Scale_Animation(Transform thisTransform, float SetDelay = 0f)
	{
	}

	public void OnSuccessUserChange()
	{
	}

	public void Popup_Open_Delay(Transform thisTransform, float SetDelay = 0.5f, Action<bool> callback = null)
	{
	}

	[IteratorStateMachine(typeof(_003COpenURL_003Ed__38))]
	public IEnumerator OpenURL(string URL)
	{
		return null;
	}

	public void OpenURL_Common(string URL)
	{
	}
}
