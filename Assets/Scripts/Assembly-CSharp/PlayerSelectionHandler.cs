using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class PlayerSelectionHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public PlayerSelectionHandler _003C_003E4__this;

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
		public _003CPlayClip_003Ed__46(int _003C_003E1__state)
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
	private Transform _playersHolder;

	[SerializeField]
	private AudioSource _audioSource;

	private int _lastSelectedPlayerIndex;

	private CharacterType _characterType;

	public static Action<CharacterType> OnGameStart;

	[SerializeField]
	private SkeletonGraphic _spineLucas;

	[SerializeField]
	private SkeletonGraphic _spineRuby;

	[SerializeField]
	private SkeletonGraphic _spineLilly;

	[SerializeField]
	private SkeletonGraphic _spineBroady;

	[SerializeField]
	private AudioClip _brodyHorn;

	[SerializeField]
	private AudioClip _brodyWroomWroom;

	[SerializeField]
	private AudioClip _brodyGo;

	[SerializeField]
	private AudioClip _rubyHorn;

	[SerializeField]
	private AudioClip _rubyWroomWroom;

	[SerializeField]
	private AudioClip _rubyGo;

	[SerializeField]
	private AudioClip _lillyHorn;

	[SerializeField]
	private AudioClip _lillyWroomWroom;

	[SerializeField]
	private AudioClip _lillyGo;

	[SerializeField]
	private AudioClip _lucasHorn;

	[SerializeField]
	private AudioClip _lucasWroomWroom;

	[SerializeField]
	private AudioClip _lucasGo;

	public static PlayerSelectionHandler Instance;

	private int _lucasIdleCount;

	private int _rubyIdleCount;

	private int _lillyIdleCount;

	private int _broadyIdleCount;

	private int _lucasIdleCountMaxCount;

	private int _rubyIdleCountMaxCount;

	private int _lillyIdleCountMaxCount;

	private int _broadyIdleCountMaxCount;

	private List<string> idleAnimations;

	private List<string> selectionAnimations;

	public void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnNextClick()
	{
	}

	public void OnPlayerSelected(Transform btn)
	{
	}

	public void ForceQuit()
	{
	}

	public void OnClose(Transform btn)
	{
	}

	private void HandleInputAndClickAnim(Transform btn)
	{
	}

	private void SetCharacterAsPlayer(bool isSelected = false)
	{
	}

	public void PlayAllIdleAnimation()
	{
	}

	private void LucasAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void LillyAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void BroadyAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void RubyAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__46))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}
}
