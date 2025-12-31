using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

public class FindLucasGiftScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public bool AnimCompletes;

		internal void _003CSetupExit_003Eb__1()
		{
		}

		internal bool _003CSetupExit_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAutoOpenGiftAfterDelay_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CAutoOpenGiftAfterDelay_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003COpenGiftAfterDelay_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindLucasGiftScreen _003C_003E4__this;

		public Transform GiftBox;

		public bool isAutoOpen;

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
		public _003COpenGiftAfterDelay_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public FindLucasGiftScreen _003C_003E4__this;

		public AudioClip CurrentClip;

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
		public _003CPlayClip_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CSetCharacterInGift_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isRubby;

		public Transform parent;

		public FindLucasGiftScreen _003C_003E4__this;

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
		public _003CSetCharacterInGift_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CSetGiftBoxParticles_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindLucasGiftScreen _003C_003E4__this;

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
		public _003CSetGiftBoxParticles_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CSetIdleState_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindLucasGiftScreen _003C_003E4__this;

		private List<string> _003ClstTempGiftBoxName_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CSetIdleState_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CSetupExit_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindLucasGiftScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

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
		public _003CSetupExit_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CShowHandHelpAnimation_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CShowHandHelpAnimation_003Ed__58(int _003C_003E1__state)
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
	private sealed class _003CStartAnimation_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FindLucasGiftScreen _003C_003E4__this;

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
		public _003CStartAnimation_003Ed__29(int _003C_003E1__state)
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

	public static FindLucasGiftScreen Instance;

	[SerializeField]
	private GameObject AllBoxParent;

	[SerializeField]
	private GameObject titleHeader;

	[SerializeField]
	private GameObject hand_clickParent;

	private Transform clickedGiftBox;

	[Header("GiftSound")]
	[SerializeField]
	private AudioClip Gift_Entry;

	[SerializeField]
	private AudioClip Gift_Shake;

	[SerializeField]
	private AudioClip Gift_OpenLucas;

	[SerializeField]
	private AudioClip Gift_OpenRubby;

	[SerializeField]
	private AudioClip Rubby_NoNo;

	[SerializeField]
	private AudioClip Lion_Surprise;

	[SerializeField]
	private AudioClip Cheering;

	[SerializeField]
	private AudioClip Gift_Shake_Haha_1;

	[SerializeField]
	private AudioClip Gift_Shake_Haha_2;

	[SerializeField]
	private AudioClip Gift_ShuffleSound;

	[SerializeField]
	private AudioClip IntroVocalSounds;

	[SerializeField]
	private AudioClip Box_Tap;

	[SerializeField]
	private AudioClip Box_Close;

	[SerializeField]
	private AudioClip Box_Close_All;

	private int GiftBoxClickedCounter;

	private List<string> lstGiftBoxName;

	private Vector3 lucasScale;

	private float AspectRatio;

	private bool FirstTimeShuffleDone;

	private int userTouchCount;

	private bool DoCallRuby;

	private int calledShuffle;

	private Transform LastClickedGiftBox;

	private int shakeSoundCounter;

	private bool isEntrySoundPlayed;

	private bool isShakeSoundPlayed;

	[SerializeField]
	private GameObject rewardBlastEffect_Particle;

	[SerializeField]
	private GameObject balloons_particle;

	private int idleCounter;

	private int oldLucasLayer;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimation_003Ed__29))]
	public IEnumerator StartAnimation()
	{
		return null;
	}

	private void ShuffleGiftBoxes()
	{
	}

	public void ShuffleAnimCompletes()
	{
	}

	private void DisableAnimator()
	{
	}

	private void HandAnimHelp()
	{
	}

	private void Autoclick()
	{
	}

	public void OnGiftBoxClick(Transform GiftBox)
	{
	}

	[IteratorStateMachine(typeof(_003COpenGiftAfterDelay_003Ed__38))]
	private IEnumerator OpenGiftAfterDelay(Transform GiftBox, bool isAutoOpen)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetCharacterInGift_003Ed__39))]
	private IEnumerator SetCharacterInGift(bool isRubby, Transform parent)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAutoOpenGiftAfterDelay_003Ed__40))]
	private IEnumerator AutoOpenGiftAfterDelay()
	{
		return null;
	}

	private void OnAnimationEventFire(string param)
	{
	}

	[IteratorStateMachine(typeof(_003CSetGiftBoxParticles_003Ed__47))]
	private IEnumerator SetGiftBoxParticles()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void _lionSpineChar_Anim_Complete_callbacks(TrackEntry trackEntry)
	{
	}

	private void _rubbySpineChar_Anim_Complete_callbacks(TrackEntry trackEntry)
	{
	}

	public void OnCloseClick(Transform GiftBox)
	{
	}

	[IteratorStateMachine(typeof(_003CSetupExit_003Ed__52))]
	private IEnumerator SetupExit()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__53))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}

	private void IdleTimerUpdate()
	{
	}

	private void ShakeOnIdle()
	{
	}

	[IteratorStateMachine(typeof(_003CSetIdleState_003Ed__57))]
	private IEnumerator SetIdleState()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowHandHelpAnimation_003Ed__58))]
	private IEnumerator ShowHandHelpAnimation()
	{
		return null;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}
}
