using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class RubyAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAlternateRubyRun_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RubyAnimation _003C_003E4__this;

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
		public _003CAlternateRubyRun_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CRubyHitLilly_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RubyAnimation _003C_003E4__this;

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
		public _003CRubyHitLilly_003Ed__27(int _003C_003E1__state)
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
	private sealed class _003CRubyRun_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RubyAnimation _003C_003E4__this;

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
		public _003CRubyRun_003Ed__26(int _003C_003E1__state)
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
	private SkeletonGraphic rubySkeletonGraphic;

	public bool allowInput;

	private bool fromAwake;

	[SerializeField]
	private AudioClip Ruby_Laugh;

	private AudioSource audioSource;

	private int rubyIdleCount;

	private List<string> Animations;

	private bool startHitAnim;

	private int otherhitcounter;

	[SerializeField]
	private Transform LucasTransform;

	[SerializeField]
	private Transform selfHitPos;

	private bool rubyLaughMode;

	private int Randomcount;

	private float rubyspeed;

	private float rubyExitSpeed;

	public bool rubyVisibility;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void CompleteEventRuby(TrackEntry trackEntry)
	{
	}

	private void AudioEventRuby(TrackEntry trackEntry, Event e)
	{
	}

	private void DidItHitMe(Transform _transform)
	{
	}

	private void OnDisable()
	{
	}

	private void Init()
	{
	}

	public void RubyHit()
	{
	}

	public void ReverseOnLucas()
	{
	}

	[IteratorStateMachine(typeof(_003CAlternateRubyRun_003Ed__20))]
	private IEnumerator AlternateRubyRun()
	{
		return null;
	}

	private void RubyRunInside()
	{
	}

	[IteratorStateMachine(typeof(_003CRubyRun_003Ed__26))]
	private IEnumerator RubyRun()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRubyHitLilly_003Ed__27))]
	public IEnumerator RubyHitLilly()
	{
		return null;
	}

	public void RubyHitbyLilly()
	{
	}

	private void EnableInput()
	{
	}
}
