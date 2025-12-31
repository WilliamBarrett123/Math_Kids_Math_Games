using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FunSnowMode_GamePlay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnClose_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FunSnowMode_GamePlay _003C_003E4__this;

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
		public _003COnClose_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FunSnowMode_GamePlay _003C_003E4__this;

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
		public _003COnNextButtonClick_003Ed__15(int _003C_003E1__state)
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

	public static FunSnowMode_GamePlay Instance;

	public AssetBundle modeBundle;

	private bool isLoadFromAsset;

	private float intial;

	private GameObject NxtBtn;

	private GameObject closeBtn;

	private GameObject GameplayBg;

	private GameObject HelpObject;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void OnNext()
	{
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__14))]
	public IEnumerator OnClose()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__15))]
	private IEnumerator OnNextButtonClick()
	{
		return null;
	}
}
