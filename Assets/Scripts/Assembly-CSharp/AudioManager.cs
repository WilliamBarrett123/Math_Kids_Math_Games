using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : Singleton<AudioManager>
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public AudioManager _003C_003E4__this;

		public float Delay;

		public SoundType _soundtype;

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
		public _003CPlayClip_003Ed__20(int _003C_003E1__state)
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

	private bool MusicStatus;

	private bool SoundStatus;

	public AudioClip buttonClickSound;

	public AudioClip gamePlayClickSound;

	public AudioSource audioSource;

	public AudioSource _SFX;

	public AudioSource _Vocals;

	public AudioSource _Motivational;

	public bool isMusicEnabled => false;

	public bool isSoundEnabled => false;

	public event Action<bool> OnMusicStatusChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<bool> OnSoundStatusChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnAudioManagerSetup()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUserChange(string obj, bool CanPlayBG)
	{
	}

	public void PlayCllipGamplay(SoundType _soundtype = SoundType.None, AudioClip CurrentClip = null)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__20))]
	public IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.None)
	{
		return null;
	}

	public void initAudioStatus()
	{
	}

	public void ToggleMusicStatus(bool state)
	{
	}

	public void ToggleSoundStatus(bool state)
	{
	}

	public void SetMusicStatus(bool Status)
	{
	}

	public void SetSoundStatus(bool Status)
	{
	}

	public void PlayButtonClickSound()
	{
	}

	public void PlayGameplayClickSound()
	{
	}

	public void PlayWindowEnterSound()
	{
	}

	public void PlayWindowExitSound()
	{
	}

	public void StopBackgroundMusicinOurStory()
	{
	}

	public void StartBackgroundMusicinOurStory()
	{
	}

	public bool IsNewLocalizationLanguage()
	{
		return false;
	}
}
