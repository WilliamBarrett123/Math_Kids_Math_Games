using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class BunnyAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBunnyHit_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BunnyAnimation _003C_003E4__this;

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
		public _003CBunnyHit_003Ed__22(int _003C_003E1__state)
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
	private SkeletonGraphic bunnySkeletonGraphic;

	[SerializeField]
	private AudioClip Bunny_Hit;

	[SerializeField]
	private AudioClip Bunny_Shaking_Snow;

	[SerializeField]
	private AudioClip Bunny_Brody_Blink;

	[SerializeField]
	private AudioClip rabbit_laugh;

	private AudioSource audioSource;

	private List<string> Animations;

	private int Bunny_Idle;

	private int bunnyGoDown;

	private bool allowInput;

	private bool startHitAnim;

	[SerializeField]
	private ParticleSystem bunnyBrushOff;

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void DidItHitMe(Transform _transform)
	{
	}

	private void CompleteEventBunny(TrackEntry trackEntry)
	{
	}

	private void BunnyDown()
	{
	}

	private void AudioEventBunny(TrackEntry trackEntry, Event e)
	{
	}

	private void OnDisable()
	{
	}

	private void Init()
	{
	}

	private void BunnyEntryAnim()
	{
	}

	public void OnBunnyClick()
	{
	}

	[IteratorStateMachine(typeof(_003CBunnyHit_003Ed__22))]
	private IEnumerator BunnyHit()
	{
		return null;
	}
}
