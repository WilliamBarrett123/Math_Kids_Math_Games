using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class PenguinAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPenguinRun_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PenguinAnimation _003C_003E4__this;

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
		public _003CPenguinRun_003Ed__31(int _003C_003E1__state)
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
	private SkeletonGraphic penguinSkeletonGraphic;

	private bool allowInput;

	private Vector3 startPosTemp;

	private Vector3 EndPostTemp;

	private Vector3 startPos;

	private Vector3 endPos;

	private bool alternateHelper;

	private bool fromAwake;

	[SerializeField]
	private AudioClip Penguin_Hit;

	[SerializeField]
	private AudioClip Penguin_Run;

	[SerializeField]
	private AudioClip Penguin_Slow_Walk_1;

	[SerializeField]
	private AudioClip Penguin_Slow_Walk_2;

	[SerializeField]
	private AudioClip Penguin_Slow_Walk_3;

	[SerializeField]
	private AudioClip Penguin_Slow_Walk_4;

	private AudioSource audioSource;

	private int penguinRunCount;

	private int penguinSlide1Count;

	private int penguinSlide2Count;

	private int AudioCounter;

	public bool allowAudio;

	private int slideType;

	private bool startHitAnim;

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void CompleteEventPenguin(TrackEntry trackEntry)
	{
	}

	private void AudioEventPenguin(TrackEntry trackEntry, Event e)
	{
	}

	private void OnDisable()
	{
	}

	private void Init(bool fromAwake = false)
	{
	}

	public void HitPenguin()
	{
	}

	private void DidItHitMe(Transform _transform)
	{
	}

	private void PenguinSlideMove(int x = -1)
	{
	}

	[IteratorStateMachine(typeof(_003CPenguinRun_003Ed__31))]
	private IEnumerator PenguinRun()
	{
		return null;
	}
}
