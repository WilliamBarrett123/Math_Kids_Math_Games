using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class Intro_Video_Friends : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartVideoAnimations_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Intro_Video_Friends _003C_003E4__this;

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
		public _003CStartVideoAnimations_003Ed__22(int _003C_003E1__state)
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
	private SkeletonGraphic _SpineLion;

	[SerializeField]
	private SkeletonGraphic _SpineRuby;

	[SerializeField]
	private SkeletonGraphic _SpineBrody;

	[SerializeField]
	private SkeletonGraphic _SpineLily;

	[SerializeField]
	private Transform Char_1;

	[SerializeField]
	private Transform Char_2;

	[SerializeField]
	private Transform Char_3;

	[SerializeField]
	private Transform Char_4;

	[SerializeField]
	private AudioClip Intro_Video_LucasRuby;

	[SerializeField]
	private AudioClip Intro_Video_BrodyLily;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private LoadingScreen _LoadingScreen;

	[NonSerialized]
	public int videoId;

	[SerializeField]
	private Sprite obj1;

	[SerializeField]
	private Sprite obj2;

	[SerializeField]
	private Sprite obj3;

	[SerializeField]
	private Image image1;

	[SerializeField]
	private Image image2;

	[SerializeField]
	private Image image3;

	[SerializeField]
	private GameObject leftGarland;

	[SerializeField]
	private GameObject rightGarland;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CStartVideoAnimations_003Ed__22))]
	public IEnumerator StartVideoAnimations()
	{
		return null;
	}

	private void _SpineLion_Anim_Event(TrackEntry trackEntry, Event e)
	{
	}

	private void LionAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void OnDisable()
	{
	}
}
