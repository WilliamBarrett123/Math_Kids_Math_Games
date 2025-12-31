using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LucasRoomAudioController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public AudioClip audioClip;

		public bool Loop;

		public LucasRoomAudioController _003C_003E4__this;

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
		public _003CPlayClip_003Ed__3(int _003C_003E1__state)
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

	public static LucasRoomAudioController Instance;

	[SerializeField]
	private AudioSource audioSource;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__3))]
	public IEnumerator PlayClip(AudioClip audioClip, float Delay = 0f, bool Loop = false)
	{
		return null;
	}

	public void StopLoopAudio()
	{
	}
}
