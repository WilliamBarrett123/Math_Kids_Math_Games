using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SnowManAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSnowManHitCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SnowManAnimation _003C_003E4__this;

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
		public _003CSnowManHitCoroutine_003Ed__13(int _003C_003E1__state)
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
	private Animator snowManAniamtor;

	[SerializeField]
	private AudioClip Snow_MAN_HIT;

	[SerializeField]
	private AudioClip Snow_MAN_HIT_Revese;

	private AudioSource audioSource;

	private bool startHitAnim;

	private bool allowInput;

	public bool Status;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Init()
	{
	}

	private void DidItHitMe(Transform _transform)
	{
	}

	private void SnowManEntry()
	{
	}

	public void SnowManHit()
	{
	}

	[IteratorStateMachine(typeof(_003CSnowManHitCoroutine_003Ed__13))]
	private IEnumerator SnowManHitCoroutine()
	{
		return null;
	}

	private void ENableINput()
	{
	}

	private void OnDisable()
	{
	}
}
