using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DualPlayer_Gameplay : Singleton<DualPlayer_Gameplay>
{
	[CompilerGenerated]
	private sealed class _003CLoadData_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DualPlayer_Gameplay _003C_003E4__this;

		private AudioClip _003CaudioOne_003E5__2;

		private AudioClip _003CaudioTwo_003E5__3;

		private AudioClip _003CaudioThree_003E5__4;

		private float _003CcountDownTime_Down_003E5__5;

		private float _003CcountDownTime_Up_003E5__6;

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
		public _003CLoadData_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003COnCorrectAnswer_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DualPlayer_Gameplay _003C_003E4__this;

		public bool isLeftPlayer;

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
		public _003COnCorrectAnswer_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

		public DualPlayer_Gameplay _003C_003E4__this;

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
		public _003CPlayClip_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CSetCurrentQuestionOnBoard_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DualPlayer_Gameplay _003C_003E4__this;

		private List<int> _003ClstOptionsAns_003E5__2;

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
		public _003CSetCurrentQuestionOnBoard_003Ed__36(int _003C_003E1__state)
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
	private Text txtQueCompleteLeft;

	[SerializeField]
	private Text txtQueCompleteRight;

	[SerializeField]
	private Text txtCorrectLeft;

	[SerializeField]
	private Text txtCorrectRight;

	[SerializeField]
	private Text txtCountDown_Left;

	[SerializeField]
	private Text txtCountDown_Right;

	[SerializeField]
	private Transform EquationLeft;

	[SerializeField]
	private Transform EquationRight;

	[SerializeField]
	private Transform ProgressFill;

	[SerializeField]
	private Transform AnsPanel_Left;

	[SerializeField]
	private Transform AnsPanel_Right;

	[SerializeField]
	private Transform ResultPanel;

	[SerializeField]
	private Transform particleCorrect;

	[SerializeField]
	private Transform particleWrong;

	private int TotalQuestions;

	private int QuestionCompleteCount;

	private int timePerQuestion;

	private string selectedDifficulty;

	private List<DualEquationDetails> lstEquations;

	private DualEquationDetails currentQuestion;

	private Tweener tweenerQueTimer;

	[SerializeField]
	private AudioClip countDownTimerStart;

	[SerializeField]
	private AudioClip countDownTimerComplete;

	[SerializeField]
	private AudioClip timeOver;

	[SerializeField]
	private AudioClip correctAns;

	[SerializeField]
	private AudioClip wrongAns;

	[SerializeField]
	private AudioClip optionLoad;

	[SerializeField]
	private AudioClip queChange;

	[SerializeField]
	private AudioClip wonSound;

	[SerializeField]
	private AudioSource thisAudioSource;

	[SerializeField]
	private AudioSource LoopAudioSource;

	private float ringParticleStartSize;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadData_003Ed__35))]
	private IEnumerator LoadData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetCurrentQuestionOnBoard_003Ed__36))]
	private IEnumerator SetCurrentQuestionOnBoard()
	{
		return null;
	}

	private void PlayTimeOverSound()
	{
	}

	private void DisableInputBeforeTimeOver()
	{
	}

	public void OnAnsOptionClick_Left(Transform thisTransform)
	{
	}

	public void OnAnsOptionClick_Right(Transform thisTransform)
	{
	}

	[IteratorStateMachine(typeof(_003COnCorrectAnswer_003Ed__41))]
	private IEnumerator OnCorrectAnswer(bool isLeftPlayer)
	{
		return null;
	}

	private void ShowResultScreen()
	{
	}

	public void OnRematchClick_Left(Transform thisTransform)
	{
	}

	private void SpawnParticleForObjects(string particleName, Transform parentObj)
	{
	}

	private List<int> GenerateAnswerOptions(int currentAns)
	{
		return null;
	}

	private void GenerateQuestion(int currentDifficulty, int numOfQue)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__47))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}
}
