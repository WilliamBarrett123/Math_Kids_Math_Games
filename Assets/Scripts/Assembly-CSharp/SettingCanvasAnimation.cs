using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SettingCanvasAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartAnimationDisplayCanvas_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SettingCanvasAnimation _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CStartAnimationDisplayCanvas_003Ed__2(int _003C_003E1__state)
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
	private List<CanvasGroup> lstCanvasObects;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimationDisplayCanvas_003Ed__2))]
	private IEnumerator StartAnimationDisplayCanvas()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void SetAlphaDown()
	{
	}
}
