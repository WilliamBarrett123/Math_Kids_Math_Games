using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class LoadingScreen_CC : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetLoadingAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScreen_CC _003C_003E4__this;

		public int CurrentAnimNumber;

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
		public _003CSetLoadingAnimation_003Ed__19(int _003C_003E1__state)
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

	private SkeletonGraphic _lionSpineChar;

	public Transform _LucasContainer;

	[SerializeField]
	private GameObject mudImage;

	[SerializeField]
	private AudioSource _src_audio;

	private int CurrentAnimIndex;

	private int CurrentAnimNumber;

	[SerializeField]
	private AudioClip ball_Jump_big_1;

	[SerializeField]
	private AudioClip ball_Jump_big_2;

	[SerializeField]
	private AudioClip mud_Jump;

	[SerializeField]
	private AudioClip pogo_Stick_1;

	[SerializeField]
	private AudioClip pogo_Stick_2;

	[SerializeField]
	private AudioClip ball_Jump_small_1;

	[SerializeField]
	private AudioClip ball_Jump_small_2;

	private List<int> lstLoadingAnimNumbers;

	[SerializeField]
	private bool iscurrentScreen1;

	private int temp;

	private int count;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void InitLoadingScreen(SkeletonGraphic _lionChar)
	{
	}

	[IteratorStateMachine(typeof(_003CSetLoadingAnimation_003Ed__19))]
	private IEnumerator SetLoadingAnimation(int CurrentAnimNumber)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void _lionSpineChar_Anim_Event_callbacks(TrackEntry trackEntry, Event e)
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}
}
