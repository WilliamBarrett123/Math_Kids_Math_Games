using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SurpriseGift_HandAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartAnimation_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SurpriseGift_HandAnimation _003C_003E4__this;

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
		public _003CStartAnimation_003Ed__5(int _003C_003E1__state)
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
	private Transform Gift_1;

	[SerializeField]
	private Transform Gift_2;

	[SerializeField]
	private Transform Gift_3;

	private List<Transform> _AnimObjs;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimation_003Ed__5))]
	private IEnumerator StartAnimation()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
