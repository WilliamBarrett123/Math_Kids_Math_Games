using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SelectLangugaeFromSystemLangaugeController : Singleton<SelectLangugaeFromSystemLangaugeController>
{
	[CompilerGenerated]
	private sealed class _003CSystemLanguageDetectFlow_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool IsKeyboardShowing;

		public SelectLangugaeFromSystemLangaugeController _003C_003E4__this;

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
		public _003CSystemLanguageDetectFlow_003Ed__10(int _003C_003E1__state)
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

	public bool IsSelectLanguageFlowButtonClick;

	private bool isCalledAnyAnimation;

	public int LaunchCountForInitalHelp;

	public bool isAppLaunchHelpShow;

	private void Start()
	{
	}

	public void CheckForHelpFlow(bool isKeyboardHelpShowing = false)
	{
	}

	private void CallKeyboardIntialHelp()
	{
	}

	private void CallMainScreenAnimationAfterSometime()
	{
	}

	public void SetPrefsForSelectLanguageFlow()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CSystemLanguageDetectFlow_003Ed__10))]
	private IEnumerator SystemLanguageDetectFlow(bool IsKeyboardShowing = false)
	{
		return null;
	}

	private void InvokeMoreAppsInitialHelp()
	{
	}

	private void InvokeWorksheetHelp()
	{
	}

	public void InvokeSpawnChangeLanguageInitialHelp()
	{
	}
}
