using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class MainScreenLionspine : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSayHi_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainScreenLionspine _003C_003E4__this;

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
		public _003CSayHi_003Ed__10(int _003C_003E1__state)
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

	public static MainScreenLionspine instance;

	private SkeletonAnimation LionSkeletonAnimation;

	public static bool IsGameLoadFirstTime;

	private int SwingCount;

	private int EyeBlickCount;

	public AudioClip Hi;

	public AudioClip GladUrHere;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LionAnimationsCompleteCallbacks(TrackEntry TrackEntry)
	{
	}

	[IteratorStateMachine(typeof(_003CSayHi_003Ed__10))]
	public IEnumerator SayHi()
	{
		return null;
	}
}
public class MainScreenLionSpine : Singleton<MainScreenLionSpine>
{
	[SerializeField]
	private AudioClip LionIntrodSound;

	[SerializeField]
	private AudioClip LionLaughSound;

	private SkeletonAnimation LionSkeletonAnimation;

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void LionSkeletonAnimationsEventCallbacks(TrackEntry TrackEntry, Event e)
	{
	}

	public void onChockWritting()
	{
	}

	public void onDusterAnimationStart()
	{
	}

	public void OnDusterComplete()
	{
	}

	private void LionAnimationsCompleteCallbacks(TrackEntry TrackEntry)
	{
	}
}
