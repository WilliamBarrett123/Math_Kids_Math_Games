using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class LionSpineMainScreenController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMainWakeAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LionSpineMainScreenController _003C_003E4__this;

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
		public _003CMainWakeAnimation_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public LionSpineMainScreenController _003C_003E4__this;

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
		public _003CPlayClip_003Ed__26(int _003C_003E1__state)
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

	public static LionSpineMainScreenController Instance;

	[SerializeField]
	private SkeletonAnimation LionSpineSkeletonGraphics;

	[SerializeField]
	private AudioClip LionIntrodSound;

	[SerializeField]
	private AudioClip LionLaughSound;

	private int IdelCount;

	private int OtherObjectCount;

	private string AnimationState;

	[HideInInspector]
	public bool isPressedAnyMode;

	private bool isShowIntroLionAnimation;

	public SkeletonAnimation LionSkeletonAnimation;

	[SerializeField]
	public Material lucasMeterial;

	private float AspectRatio;

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

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void SetLoinposition()
	{
	}

	private void OnDestroy()
	{
	}

	private void LionAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private bool isMainScreenEnable()
	{
		return false;
	}

	public void MainLionWakeAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CMainWakeAnimation_003Ed__22))]
	private IEnumerator MainWakeAnimation()
	{
		return null;
	}

	private void LionSkeletonAnimationsEventCallbacks(TrackEntry TrackEntry, Event e)
	{
	}

	public void MainScreenLionIdleAnimation()
	{
	}

	public void stopPlayClipWhenPressedAnyMode()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__26))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}

	public void Lion_IntroductionAnimation()
	{
	}

	private void Lion_StopIntroductionAnimation()
	{
	}
}
