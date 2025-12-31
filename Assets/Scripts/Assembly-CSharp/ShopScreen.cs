using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScrollAnimFromRightToLeft_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopScreen _003C_003E4__this;

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
		public _003CScrollAnimFromRightToLeft_003Ed__6(int _003C_003E1__state)
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

	private GameObject selectedObj;

	public ScrollRect _Scroll;

	private int ShopCount;

	private void Start()
	{
	}

	private void CheckForShopShare()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CScrollAnimFromRightToLeft_003Ed__6))]
	private IEnumerator ScrollAnimFromRightToLeft()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void onShopButtonClick(GameObject currentObj)
	{
	}
}
