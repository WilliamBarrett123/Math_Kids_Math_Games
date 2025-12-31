using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class AnswerPanelAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

		public AnswerPanelAnimation _003C_003E4__this;

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

	public static AnswerPanelAnimation instance;

	[SerializeField]
	private List<Vector3> vector3sPos;

	public Vector3 vector3start;

	public Vector3 vector3end;

	private float speed;

	public Transform Handhelp;

	public Transform parentofHelp;

	private int IdleCount;

	public bool IdleHelp;

	private Transform lastClickedSnowBall;

	private bool allowInput;

	private bool allowInputOutside;

	[SerializeField]
	private ParticleSystem Number_Snow_Blast;

	[SerializeField]
	private ParticleSystem Number_Snow_Blast_Penguin;

	private AudioSource audioSource;

	[SerializeField]
	private AudioClip Number_SnowBall_Blast;

	[SerializeField]
	private Vector3[] penguinPoss;

	[SerializeField]
	private SkeletonGraphic penguin;

	[SerializeField]
	private Transform penguinSnowBall;

	[SerializeField]
	private Transform startPosPeng;

	[SerializeField]
	private Transform t0;

	[SerializeField]
	private Transform t1;

	[SerializeField]
	private Transform t2;

	[SerializeField]
	private Transform t3;

	[SerializeField]
	private Transform t4;

	[SerializeField]
	private Transform t5;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void InitialAnim()
	{
	}

	public void spawnHelp()
	{
	}

	private void StartStopJump()
	{
	}

	public void OnFirstSnowBallAnimation_Done()
	{
	}

	public void SnowBallClick(GameObject _gameObject)
	{
	}

	public void ResetCanvas()
	{
	}

	public void EnableInput()
	{
	}

	public void DisableInputExtra()
	{
	}

	public void EnableInputExtra()
	{
	}

	public void RightAnimation()
	{
	}

	private void ThrowBall()
	{
	}

	public void WrongAnimation()
	{
	}

	public void IdleMove()
	{
	}

	private void StartStopJumpSecond()
	{
	}

	private void StartJumpForAllObjects()
	{
	}

	public void StopAllAniamtions()
	{
	}

	public void PlayObjectSound(string number, float delay = 0f)
	{
	}

	public void PlayObjectSound2(string number)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__46))]
	public IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}
}
