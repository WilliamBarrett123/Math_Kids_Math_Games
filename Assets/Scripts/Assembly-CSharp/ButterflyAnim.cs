using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ButterflyAnim : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CsetVal_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ButterflyAnim _003C_003E4__this;

		private float _003Ci_003E5__2;

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
		public _003CsetVal_003Ed__15(int _003C_003E1__state)
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
	private Sprite img_butterfly0;

	[SerializeField]
	private Sprite img_butterfly1;

	[SerializeField]
	private Sprite img_butterfly2;

	[SerializeField]
	private Sprite img_butterfly3;

	[SerializeField]
	private Image ButterFly;

	private Animator getComponentAnim;

	private Animator ButterflyAnimtor;

	private float oldX;

	private float oldY;

	private float angle;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void mainMenuButterFly(string Side)
	{
	}

	public void GamePlayButterFly()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CsetVal_003Ed__15))]
	public IEnumerator setVal()
	{
		return null;
	}

	public void slowFly()
	{
	}

	public void fastFly()
	{
	}

	public void destroyCurrent()
	{
	}
}
