using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Spine;
using Spine.Unity;
using UnityEngine;

public class CarModeContent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayBackgroundAnimation2_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModeContent _003C_003E4__this;

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
		public _003CPlayBackgroundAnimation2_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public CarModeContent _003C_003E4__this;

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
		public _003CPlayClip_003Ed__108(int _003C_003E1__state)
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

	public static CarModeContent Instance;

	[SerializeField]
	private SkeletonGraphic _spineLucas;

	[SerializeField]
	private SkeletonGraphic _spineRuby;

	[SerializeField]
	private SkeletonGraphic _spineLilly;

	[SerializeField]
	private SkeletonGraphic _spineBroady;

	[SerializeField]
	private RectTransform _gamePlayBackground;

	[SerializeField]
	private RectTransform _bgMove;

	[SerializeField]
	private RectTransform _frame1;

	[SerializeField]
	private RectTransform _frame2;

	[SerializeField]
	private RectTransform _frame3;

	[SerializeField]
	private RectTransform _charactersContainer;

	[SerializeField]
	private RectTransform _firstMiddleRoad;

	[SerializeField]
	private RectTransform _bgNotch;

	[SerializeField]
	private GameObject _startLine;

	[SerializeField]
	private GameObject _powerPrefab;

	[SerializeField]
	private GameObject _hurdlePrefab;

	[SerializeField]
	private GameObject _endLinePrefab;

	[SerializeField]
	private GameObject _playerSelectionPopup;

	[SerializeField]
	private GameObject _gamePlay;

	[SerializeField]
	private GameObject _gameEndScreen;

	[SerializeField]
	private List<AudioClip> _lucasClips;

	[SerializeField]
	private List<AudioClip> _rubyClips;

	[SerializeField]
	private List<AudioClip> _brodyClips;

	[SerializeField]
	private AudioClip _letsGoSound;

	[SerializeField]
	private AudioClip _crowdCheerSound;

	[SerializeField]
	private AudioClip _wrongClick;

	[SerializeField]
	private AudioClip _rightClick;

	[SerializeField]
	private AudioClip _winnerScreen;

	[SerializeField]
	private AudioClip _raceModeBgSound;

	[SerializeField]
	private AudioClip _questionPop;

	[SerializeField]
	private AudioSource _thisAudioSource;

	[SerializeField]
	private AudioClip _lucasEnergy;

	[SerializeField]
	private AudioClip _lucasHurdle;

	[SerializeField]
	private AudioClip _brodyEnergy;

	[SerializeField]
	private AudioClip _brodyHurdle;

	[SerializeField]
	private AudioClip _lillyRubyEnergy;

	[SerializeField]
	private AudioClip _lillyRubyHurdle;

	private List<RectTransform> _allCharacters;

	private RectTransform _rectLucas;

	private RectTransform _rectRuby;

	private RectTransform _rectLilly;

	private RectTransform _rectBroady;

	private List<float> _characterYPositions;

	private List<int> _characterPositionLayer;

	public CharacterType _mainCharacterType;

	public CharacterType _winnerChar;

	private Vector2 currentResolution;

	private int _mainCharacterTrackIndex;

	private Tween bg_move_tween;

	private int _lastIndexOfRightAnswer;

	private int _lastIndexOfWrongAnswer;

	private int _powerSpawnCount;

	private int _maxPowerSpawnCount;

	private int _hurdleSpawnCount;

	private int _maxHurdleSpawnCount;

	private int _specialObjectRemainForOtherPlayer;

	private int _lucasIdleCount;

	private int _rubyIdleCount;

	private int _lillyIdleCount;

	private int _broadyIdleCount;

	private int _lucasIdleCountMaxCount;

	private int _rubyIdleCountMaxCount;

	private int _lillyIdleCountMaxCount;

	private int _broadyIdleCountMaxCount;

	private int _lucasIdleDrive;

	private int _rubyIdleDrive;

	private int _lillyIdleDrive;

	private int _broadyIdleDrive;

	public void GetWinnerPlayer()
	{
	}

	public void PlayLucasSound(string clipName)
	{
	}

	public void PlayBrodySound(string clipName)
	{
	}

	public void PlayRubyLillySound(string clipName)
	{
	}

	private void Awake()
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

	public void EnablePlayerSelectionPopup()
	{
	}

	private void AdjustDividers()
	{
	}

	private void AdjustCharacters()
	{
	}

	public void ResolutionEvent(Vector2 _temp)
	{
	}

	private void OnRaceEnd()
	{
	}

	public void HideMovingBackground()
	{
	}

	public GameObject GetGameEndScreen()
	{
		return null;
	}

	private void Start()
	{
	}

	public void SetDefaultScreenSetup()
	{
	}

	private void PlayBackgroundAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayBackgroundAnimation2_003Ed__67))]
	private IEnumerator PlayBackgroundAnimation2()
	{
		return null;
	}

	public void SpawnPowerUp(int index, bool isForOtherPlayer)
	{
	}

	public void SpawnHurdle(int index, bool isForOtherPlayer)
	{
	}

	public void SpawnEndLine()
	{
	}

	private void OnGameStart(CharacterType characterType)
	{
	}

	private void OnCountDownComplete()
	{
	}

	private void PlayCheerSound()
	{
	}

	public void PlayQuestionPopSound()
	{
	}

	public void PlayWrongButtonClick()
	{
	}

	public void PlayRightButtonClick()
	{
	}

	private void ShowStartLineOnRaceStart(bool isShow)
	{
	}

	public void PlayAllIdleAnimation()
	{
	}

	public void PlayLucasAnimation(string animName, bool isFirstPlay = false)
	{
	}

	public void PlayRubyAnimation(string animName, bool isFirstPlay = false)
	{
	}

	public void PlayLillyAnimation(string animName, bool isFirstPlay = false)
	{
	}

	public void PlayBroadyAnimation(string animName, bool isFirstPlay = false)
	{
	}

	private void LucasAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void RubyAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void LillyAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void BroadyAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	public void ApplyFadeInBackgroundSound(bool isFade)
	{
	}

	public void Play321Sound()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__108))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}
}
