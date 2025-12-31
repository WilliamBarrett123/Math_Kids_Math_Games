using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpwaning_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string SpecialScreeName;

		public Transform _Parent;

		public ScreenManager _003C_003E4__this;

		private bool _003CisAllowScreenTransition_003E5__2;

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
		public _003CSpwaning_003Ed__12(int _003C_003E1__state)
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

	public static ScreenManager Instance;

	public int CompletionCount;

	public int LucasSpecialScreenCounter;

	public List<int> SpecialScreenList;

	private List<string> ScreenNamesforGame;

	private bool isLucasSpecialScreen;

	private string _name;

	public GameObject SpwnedScreenName;

	private void Awake()
	{
	}

	public bool isNextScreenSpecialScreen()
	{
		return false;
	}

	public bool isNextScreenStickerOrStamp()
	{
		return false;
	}

	public void SpawnSpecialScreen(Transform _Parent = null)
	{
	}

	[IteratorStateMachine(typeof(_003CSpwaning_003Ed__12))]
	private IEnumerator Spwaning(string SpecialScreeName, Transform _Parent)
	{
		return null;
	}

	public void OnCloseButtonPressed()
	{
	}

	public bool checkPreiousScreen()
	{
		return false;
	}

	public void DestroyPreviousScreens()
	{
	}

	public bool WasLucasDancing()
	{
		return false;
	}
}
