using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LeafAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CHideLeaf_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeafAnimation _003C_003E4__this;

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
		public _003CHideLeaf_003Ed__7(int _003C_003E1__state)
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

	public Animator LeafAnimator;

	public AudioClip clip_close;

	public AudioClip clip_Open;

	private AudioSource thisAudioSource;

	private void Awake()
	{
	}

	public void CloseLeaf(bool openAutimatically = false, float openDelay = 1.3f)
	{
	}

	public void OpenLeaf()
	{
	}

	[IteratorStateMachine(typeof(_003CHideLeaf_003Ed__7))]
	private IEnumerator HideLeaf()
	{
		return null;
	}
}
