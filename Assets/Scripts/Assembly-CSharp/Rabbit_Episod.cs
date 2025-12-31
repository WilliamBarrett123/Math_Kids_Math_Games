using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class Rabbit_Episod : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRabbitEntry_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Rabbit_Episod _003C_003E4__this;

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
		public _003CRabbitEntry_003Ed__10(int _003C_003E1__state)
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

	public static Rabbit_Episod instance;

	private SkeletonAnimation RabbitSkeletonEpisode;

	public GameObject GoodJob;

	private int IdleCount;

	[Header("Sound - RabbitGamePlay :")]
	public AudioClip DoubleJumpSound;

	public AudioClip laughSound;

	public AudioClip matchJumpSound;

	public AudioClip goodJobSound;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CRabbitEntry_003Ed__10))]
	public IEnumerator RabbitEntry(float time)
	{
		return null;
	}

	public void OnRightMatch()
	{
	}

	private void LionAnimationsCompleteCallbacks(TrackEntry TrackEntry)
	{
	}
}
