using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChangeLanguageHelp : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003ConScreenAnim_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChangeLanguageHelp _003C_003E4__this;

		public bool isNextClick;

		private Transform _003CcurrentScreen_003E5__2;

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
		public _003ConScreenAnim_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CshowAnim_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChangeLanguageHelp _003C_003E4__this;

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
		public _003CshowAnim_003Ed__18(int _003C_003E1__state)
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

	[SerializeField]
	private GameObject screenContainer;

	[SerializeField]
	private GameObject completeHelpText;

	[SerializeField]
	private GameObject btnLanguage;

	private int currentPageCount;

	private string previousScreenName;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}

	private void SelectFirstSelectable()
	{
	}

	public void onNextButtonClick()
	{
	}

	public void onBackButtonClick()
	{
	}

	public void onVideosButtonClick(string VideoName)
	{
	}

	[IteratorStateMachine(typeof(_003ConScreenAnim_003Ed__14))]
	private IEnumerator onScreenAnim(bool isNextClick)
	{
		return null;
	}

	public void onOurStoryButtonClick()
	{
	}

	public void onPlayVideoButtonClick()
	{
	}

	public void onButtonClick()
	{
	}

	[IteratorStateMachine(typeof(_003CshowAnim_003Ed__18))]
	private IEnumerator showAnim()
	{
		return null;
	}

	private void showMaskLayer(int pageCount)
	{
	}
}
