using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class LucasRoomCharacterAnimations : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetIDleAnimation_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LucasRoomCharacterAnimations _003C_003E4__this;

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
		public _003CSetIDleAnimation_003Ed__31(int _003C_003E1__state)
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
	public SkeletonGraphic LucasCCSkelton;

	public GameObject BlockImage;

	public GameObject BigBlockImage;

	public static LucasRoomCharacterAnimations Instance;

	[SerializeField]
	private AudioClip _TrumpetSound;

	[SerializeField]
	private AudioClip _TrumpetSound_2;

	[SerializeField]
	private AudioClip _SexophoneSound;

	[SerializeField]
	private AudioClip _FluteSound;

	[SerializeField]
	private AudioClip _Front_BugalSound_1;

	[SerializeField]
	private AudioClip _Front_BugalSound_2;

	private bool _FrontBugalSound1Play;

	public bool ButtonsClickble;

	private int LucasIdleAnimCounter;

	[SerializeField]
	private AudioClip Touch_Hi_iam_Lucas;

	[SerializeField]
	private AudioClip Touch_Hi;

	[SerializeField]
	private AudioClip DoyouRemeber;

	[SerializeField]
	private AudioClip IamLucas;

	[SerializeField]
	private AudioSource audioSource;

	private bool IsIdealAnimationCompete;

	public GameObject Radio;

	[SerializeField]
	private AudioClip Laugh_bestfrd;

	[SerializeField]
	private AudioClip Laugh_always;

	public bool ISlucasIDleCorutineISRunning;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 vector)
	{
	}

	private void SetScalePosAccrodingToResolution()
	{
	}

	private void LucasEventCallBacks(TrackEntry trackEntry, Event e)
	{
	}

	private void LucasCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	[IteratorStateMachine(typeof(_003CSetIDleAnimation_003Ed__31))]
	private IEnumerator SetIDleAnimation()
	{
		return null;
	}

	private void PlayClip(AudioClip CurrentClip, float Delay = 0f, bool IsplayOneShot = false)
	{
	}

	public void CheckCoruotineIsRunning()
	{
	}

	public void ClearTrack(SkeletonGraphic _skeletonGraphic)
	{
	}
}
