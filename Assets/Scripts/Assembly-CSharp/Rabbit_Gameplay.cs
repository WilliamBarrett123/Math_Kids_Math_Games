using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class Rabbit_Gameplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRabbitEntry_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Rabbit_Gameplay _003C_003E4__this;

		public float time;

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
		public _003CRabbitEntry_003Ed__21(int _003C_003E1__state)
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

	public static Rabbit_Gameplay instance;

	private SkeletonAnimation RabbitSkeletonAnimation;

	public GameObject GoodJob;

	public GameObject WellDone;

	public bool IsRabbitInScreen;

	public bool isRabbitGoodJob;

	public string lastAnimationState;

	public static int GoodJobCount;

	private RectTransform rabbitRectTransform;

	private int IdleCount;

	[Header("Sound - RabbitGamePlay :")]
	public AudioClip matchJumpSound;

	private Vector3 Scale35;

	private Vector3 Scale40;

	private float margin;

	private float fixscale;

	public bool rubyGoingtoCC;

	private void Start()
	{
	}

	private void updatescale()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateRubbyPos()
	{
	}

	[IteratorStateMachine(typeof(_003CRabbitEntry_003Ed__21))]
	public IEnumerator RabbitEntry(float time)
	{
		return null;
	}

	public void OnRightMatch()
	{
	}

	public void RabbitEnterWithBoard()
	{
	}

	public void HappyJumpRabbit()
	{
	}

	private void RabbitAnimationsCompleteCallbacks(TrackEntry TrackEntry)
	{
	}
}
