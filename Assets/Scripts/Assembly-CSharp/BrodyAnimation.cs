using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class BrodyAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBrodyHitLilly_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BrodyAnimation _003C_003E4__this;

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
		public _003CBrodyHitLilly_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CDogRun_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BrodyAnimation _003C_003E4__this;

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
		public _003CDogRun_003Ed__41(int _003C_003E1__state)
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

	public static BrodyAnimation instance;

	[SerializeField]
	private ParticleSystem BrodySlider_Running_Snow;

	[SerializeField]
	private ParticleSystem Dog_Running_Snow;

	[SerializeField]
	private SkeletonGraphic dogSkeletonGraphic;

	[SerializeField]
	private SkeletonGraphic brodySkeletonGraphic;

	public bool allowInput;

	private bool wasDogHit;

	[SerializeField]
	private AudioClip dog_barking_1;

	[SerializeField]
	private AudioClip dog_barking_2;

	private bool fromAwake;

	[SerializeField]
	private AudioClip Dog_Walk;

	[SerializeField]
	private AudioClip Dog_Run;

	[SerializeField]
	private AudioClip Dog_Run_Snow;

	[SerializeField]
	private AudioClip Dog_Hit_Now;

	[SerializeField]
	private AudioClip Brody_Blink;

	[SerializeField]
	private AudioClip Brody_Falling;

	[SerializeField]
	private AudioClip Brody_Happy;

	[SerializeField]
	private AudioClip Brody_Laugh_1;

	[SerializeField]
	private AudioClip Brody_Laugh_2;

	private AudioSource audioSource;

	private AudioSource brodyAudioSource;

	private int brodyIdleCount;

	private int dogWalkCount;

	private int dogRunCount;

	private bool startHitAnim;

	private bool lookleft;

	private List<string> Animations;

	[SerializeField]
	private float slowMoveSpeed;

	[SerializeField]
	private float runSpeed;

	public float x;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void CompleteEventBrody(TrackEntry trackEntry)
	{
	}

	private void CompleteEventDog(TrackEntry trackEntry)
	{
	}

	private void AudioEventBrody(TrackEntry trackEntry, Event e)
	{
	}

	private void AudioEventDog(TrackEntry trackEntry, Event e)
	{
	}

	private void DidItHitMe(Transform _transform)
	{
	}

	private void OnDisable()
	{
	}

	private void Init(bool fromAwake = false)
	{
	}

	public void HitDog()
	{
	}

	public void HitBrody()
	{
	}

	private void DogSlowMove()
	{
	}

	[IteratorStateMachine(typeof(_003CDogRun_003Ed__41))]
	private IEnumerator DogRun()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBrodyHitLilly_003Ed__43))]
	public IEnumerator BrodyHitLilly()
	{
		return null;
	}

	public void BrodyWonder()
	{
	}

	public void BrodyHitbyLilly()
	{
	}

	private void EnableInput()
	{
	}
}
