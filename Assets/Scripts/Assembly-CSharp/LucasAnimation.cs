using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class LucasAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public LucasAnimation _003C_003E4__this;

		public Transform _transform;

		internal void _003CThrowSnowBall_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CEndScreenAnimation_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LucasAnimation _003C_003E4__this;

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
		public _003CEndScreenAnimation_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CThrowSnowBall_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LucasAnimation _003C_003E4__this;

		public Transform _transform;

		public float time;

		private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

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
		public _003CThrowSnowBall_003Ed__48(int _003C_003E1__state)
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

	public static LucasAnimation instance;

	[SerializeField]
	private SkeletonGraphic LucasSkeletonGraphic;

	[SerializeField]
	private AudioClip no_no_no;

	[SerializeField]
	private AudioClip clapping;

	[SerializeField]
	private AudioClip happy_jump;

	[SerializeField]
	private AudioClip wohooo_jump;

	[SerializeField]
	private AudioClip wohooooooooooo;

	[SerializeField]
	private AudioClip Hit_Ball_tree_Lucas;

	[SerializeField]
	private AudioClip Hit_Snow_to_Lucas;

	[SerializeField]
	private AudioClip Point_Laugh;

	[SerializeField]
	private AudioClip Sled_Push;

	[SerializeField]
	private AudioClip Snow_Ball_Play_jump;

	[SerializeField]
	private AudioClip Snow_up;

	[SerializeField]
	private AudioClip SnowBall_Happy1;

	[SerializeField]
	private AudioClip Touch_Left_Leg_Jump;

	[SerializeField]
	private AudioClip Touch_Tummy2;

	[SerializeField]
	private AudioClip Tummy_Hand_1;

	public ParticleSystem Lucas_Add_Slider;

	public ParticleSystem Lucas_SLider_Snow_1;

	public ParticleSystem Lucas_SLider_Snow_2;

	public ParticleSystem Lu_Snow_Up;

	private List<string> Animations;

	private int lucasIdleCount;

	private AudioSource audioSource;

	public ActiveSlideDownObject activeSlideDownObject;

	private int rightAnimationCount;

	private int wrongAnimationCount;

	public int funthrowcounter;

	public int funthrowwincounter;

	[SerializeField]
	private PlaySectionRandomSpawn playSectionRandomSpawn;

	private bool allowEnd;

	[SerializeField]
	private AudioClip lets_have_some_fun;

	[SerializeField]
	private AudioClip this_is_so_much_fun;

	[SerializeField]
	private ParticleSystem SnowBalll_Hit;

	[SerializeField]
	private ParticleSystem SnowBalll_Hit_Lucas;

	public AudioClip Snowball_Hit_Common;

	public Transform snowBall;

	public Transform startPos;

	public static bool allowInput;

	private bool selfTapAllow;

	[SerializeField]
	private GameObject sled1;

	[SerializeField]
	private GameObject sled2;

	public static event Action<Transform> HitSomething
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void LucasClimbHill()
	{
	}

	public void LucasClimbHillFinal()
	{
	}

	private void OnEnable()
	{
	}

	private void CompleteEventLucas(TrackEntry trackEntry)
	{
	}

	public void LucasIdle()
	{
	}

	private void AudioEventLucas(TrackEntry trackEntry, Event e)
	{
	}

	private void UpdateSledCanvas()
	{
	}

	private void OnDisable()
	{
	}

	public void SlideDownHill()
	{
	}

	public void EndSlideDownHill()
	{
	}

	public void RightAniamtion()
	{
	}

	public void WrongAniamtion()
	{
	}

	[IteratorStateMachine(typeof(_003CEndScreenAnimation_003Ed__44))]
	private IEnumerator EndScreenAnimation()
	{
		return null;
	}

	public void LucasAniamtionOnThrows(ThrowType throwType, Transform _transform)
	{
	}

	[IteratorStateMachine(typeof(_003CThrowSnowBall_003Ed__48))]
	private IEnumerator ThrowSnowBall(float time, Transform _transform)
	{
		return null;
	}

	public void OnLucasClick()
	{
	}

	private void AllowSelfInput()
	{
	}
}
