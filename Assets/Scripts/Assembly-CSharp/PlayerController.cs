using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public bool isLoop;

		public PlayerController _003C_003E4__this;

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
		public _003CPlayClip_003Ed__22(int _003C_003E1__state)
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
	private Transform _tire1;

	[SerializeField]
	private Transform _tire2;

	[SerializeField]
	private RectTransform _gameplayBG;

	public CharacterType CharacterType;

	public Transform MainParent;

	public int PlayerTrackIndex;

	private RectTransform _thisRect;

	private List<float> _trackDestinationPoints;

	private CharacterType _mainCharacterType;

	private int _trackPointIndex;

	private float _destinationPoint;

	private float _sourcePoint;

	private readonly float _rotationSpeed;

	private Vector3 _defaultScaling;

	private Vector3 _defaultPosition;

	private bool _isCarsMoving;

	[SerializeField]
	private AudioSource _audioSource;

	[SerializeField]
	private AudioClip _carRunIdle;

	[SerializeField]
	private AudioClip _carHurdle;

	[SerializeField]
	private AudioClip _carPower;

	[SerializeField]
	private AudioClip _carWroomForRight;

	[SerializeField]
	private AudioClip _carBreakForWrong;

	private bool isDefaultSet;

	private Tween postiveMove_tween;

	private Tween nevgativeMove_tween;

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__22))]
	private IEnumerator PlayClip(AudioClip CurrentClip, bool isLoop = false, float Delay = 0f)
	{
		return null;
	}

	private void Update()
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

	private void OnGameStart(CharacterType type)
	{
	}

	private void OnRaceEnd()
	{
	}

	private void OnCountDownComplete()
	{
	}

	private void AnimateCar()
	{
	}

	private void OnRightAnswer()
	{
	}

	private void OnWrongAnswer()
	{
	}

	private void DefaultAnimatoinOfCar()
	{
	}

	private void SpeedBoost()
	{
	}

	private void BoostOtherPlayers()
	{
	}

	private void ApplyBreak()
	{
	}

	private void SetTrackDestinationPoints()
	{
	}

	private float GetRandom(float a, float b)
	{
		return 0f;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void ShowGameEndScreen()
	{
	}
}
