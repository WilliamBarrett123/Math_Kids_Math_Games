using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class LillyAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAutoHitRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LillyAnimation _003C_003E4__this;

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
		public _003CAutoHitRoutine_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CGetHit_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LillyAnimation _003C_003E4__this;

		private bool _003Cboom_003E5__2;

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
		public _003CGetHit_003Ed__29(int _003C_003E1__state)
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

	public static LillyAnimation instance;

	[SerializeField]
	private SkeletonGraphic lillySkeletonGraphic;

	[SerializeField]
	private GameObject brody;

	[SerializeField]
	private GameObject ruby;

	public bool allowInput;

	private AudioSource audioSource;

	private int lillyIdleCount;

	private List<string> Animations;

	[SerializeField]
	private AudioClip Lilly_laugh;

	[SerializeField]
	private AudioClip Lilly_laugh1;

	[SerializeField]
	private AudioClip Lilly_Ohh;

	[SerializeField]
	private AudioClip Lilly_Yeahhh;

	private int autoHitCount;

	[SerializeField]
	private RectTransform brodyHitPos;

	[SerializeField]
	private RectTransform bordyParticle;

	[SerializeField]
	private RectTransform Rubyparicle;

	private int otherhitcounter;

	[SerializeField]
	private Transform selfHitPos;

	private int autoThrowCount;

	[SerializeField]
	private Transform LillyHitPos;

	[SerializeField]
	private Transform LillySnowBall;

	[SerializeField]
	private Transform LillySnowBallParticle;

	[SerializeField]
	private Transform BrodyThrowPos;

	[SerializeField]
	private Transform RubyThrowPos;

	private float lillyspeed;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void CompleteEventLilly(TrackEntry trackEntry)
	{
	}

	private void AudioEventLilly(TrackEntry trackEntry, Event e)
	{
	}

	private void OnDisable()
	{
	}

	private void Init()
	{
	}

	private void AutoHit()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoHitRoutine_003Ed__20))]
	private IEnumerator AutoHitRoutine()
	{
		return null;
	}

	public void ThrowSnowBallTo(bool toBrody = true)
	{
	}

	public void LillyHit()
	{
	}

	[IteratorStateMachine(typeof(_003CGetHit_003Ed__29))]
	private IEnumerator GetHit()
	{
		return null;
	}

	public void ThrowSnowBall(bool fromBrody = true)
	{
	}

	private void LillyRunInside()
	{
	}
}
