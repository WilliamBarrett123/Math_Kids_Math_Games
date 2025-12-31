using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class RabbitRunning : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGoodJobDance_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RabbitRunning _003C_003E4__this;

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
		public _003CGoodJobDance_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CRabbitMoveAfterGoodJOb_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RabbitRunning _003C_003E4__this;

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
		public _003CRabbitMoveAfterGoodJOb_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CRabbitPassWithJump_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RabbitRunning _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CRabbitPassWithJump_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CRabbitWithSketing_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RabbitRunning _003C_003E4__this;

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
		public _003CRabbitWithSketing_003Ed__28(int _003C_003E1__state)
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

	public static RabbitRunning instance;

	private SkeletonAnimation RabbitSkelaton;

	private int rabbitdance;

	private int Sketboard_KickCount;

	public string AnimationState;

	public GameObject LeftHand;

	public GameObject RightHand;

	[Header("Sound - RabbitRunning :")]
	public AudioClip GiftConfitteSound;

	public AudioClip GiftHappySound;

	public AudioClip StickerLaughSound;

	public AudioClip goodJobSound;

	public AudioClip DoubleJumpSound;

	private float margin;

	private float fixscale;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void updatescale()
	{
	}

	private void RabbitSkeletonRunning_state_Event(TrackEntry TrackEntry, Event e)
	{
	}

	private void RabbitAnimationsCompleteCallbacks(TrackEntry TrackEntry)
	{
	}

	private void LionPassing()
	{
	}

	[IteratorStateMachine(typeof(_003CRabbitPassWithJump_003Ed__20))]
	public IEnumerator RabbitPassWithJump()
	{
		return null;
	}

	public void HideRabbit()
	{
	}

	private void OnEnable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CGoodJobDance_003Ed__25))]
	public IEnumerator GoodJobDance()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRabbitMoveAfterGoodJOb_003Ed__26))]
	public IEnumerator RabbitMoveAfterGoodJOb()
	{
		return null;
	}

	public void StickerCollectScreenRabit()
	{
	}

	[IteratorStateMachine(typeof(_003CRabbitWithSketing_003Ed__28))]
	public IEnumerator RabbitWithSketing()
	{
		return null;
	}

	private void HideRuby()
	{
	}
}
