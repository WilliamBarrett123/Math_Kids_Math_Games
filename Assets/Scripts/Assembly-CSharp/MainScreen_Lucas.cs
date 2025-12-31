using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class MainScreen_Lucas : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetlion_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainScreen_Lucas _003C_003E4__this;

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
		public _003CSetlion_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CmoveLionInside_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainScreen_Lucas _003C_003E4__this;

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
		public _003CmoveLionInside_003Ed__29(int _003C_003E1__state)
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

	public Transform LoadingScreen;

	public static MainScreen_Lucas Instance;

	public GameObject LucasCC;

	public SkeletonGraphic _LucasMain;

	public SkeletonAnimation _RubyCC;

	private GameObject GiftScreen;

	private GameObject BalloonScreen;

	private GameObject LucasInGiftScreen;

	[NonSerialized]
	public bool isFromDemoScreen;

	public bool isAnimationPlaying;

	public Transform RubyCCparent;

	public bool lucasIsOutside;

	public static float LoadingScreenTime;

	private int oldLucasLayer;

	private int oldRubbyLayer;

	private int isSortingGroupAdded;

	[Range(0f, 10f)]
	[Space(20f)]
	public float Sec;

	public List<_LucasState> lstStates;

	public int idleTimeCounter;

	public bool isShowLucasInGameplay;

	private int lionStateIndex;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void SpawnLucasCC()
	{
	}

	public void OnLoadingScreen()
	{
	}

	public void OnLucasRoomButtonClick()
	{
	}

	public void LoadLucasRoom()
	{
	}

	public void CloseActiveScreen()
	{
	}

	public void OnInitCharacterInSpecificScreen_Lucas(_LucasState _state, Transform _parent)
	{
	}

	public void OnInitCharacterInSpecificScreen_Ruby(_LucasState _state, Transform _parent)
	{
	}

	[IteratorStateMachine(typeof(_003CSetlion_003Ed__26))]
	private IEnumerator Setlion()
	{
		return null;
	}

	public void DisableLucas()
	{
	}

	public void DisableRuby()
	{
	}

	[IteratorStateMachine(typeof(_003CmoveLionInside_003Ed__29))]
	public IEnumerator moveLionInside()
	{
		return null;
	}

	public void UpdateStatusForGameplay(CharacterModuleStatus _status, bool autoNext = false)
	{
	}

	public void IdleTimerUpdate()
	{
	}
}
