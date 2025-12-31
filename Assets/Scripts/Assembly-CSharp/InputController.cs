using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

public class InputController : Singleton<InputController>
{
	[CompilerGenerated]
	private sealed class _003CEnableInputAfterDelay_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public InputController _003C_003E4__this;

		private float _003CpauseTime_003E5__2;

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
		public _003CEnableInputAfterDelay_003Ed__13(int _003C_003E1__state)
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

	private static bool _canInput;

	public bool IsIntialHelpEnable;

	public static bool isLoading;

	public EventSystem UIEventSystem;

	public static bool canInput => false;

	public static event Action OnBackButtonPressedEvent
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

	public void DisableInput()
	{
	}

	public void EnableInput()
	{
	}

	public void DisableInputForDelay(float delay = 0.5f, bool isDisableInputSystem = false)
	{
	}

	public void DisableInputForDelayKeyboard(float delay = 0.5f)
	{
	}

	[IteratorStateMachine(typeof(_003CEnableInputAfterDelay_003Ed__13))]
	private IEnumerator EnableInputAfterDelay(float delay)
	{
		return null;
	}

	private void Update()
	{
	}
}
