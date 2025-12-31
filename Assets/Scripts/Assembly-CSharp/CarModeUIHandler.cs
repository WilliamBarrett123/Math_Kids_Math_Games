using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CarModeUIHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CHandleAnswer_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModeUIHandler _003C_003E4__this;

		public Transform btn;

		private bool _003CisRight_003E5__2;

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
		public _003CHandleAnswer_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CSetAnswers_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModeUIHandler _003C_003E4__this;

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
		public _003CSetAnswers_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CSetEquation_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModeUIHandler _003C_003E4__this;

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
		public _003CSetEquation_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CShowTimerOnPlayerIdle_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModeUIHandler _003C_003E4__this;

		private Text _003CcounterText_003E5__2;

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
		public _003CShowTimerOnPlayerIdle_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CStartCountdownAfterPanelMove_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarModeUIHandler _003C_003E4__this;

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
		public _003CStartCountdownAfterPanelMove_003Ed__31(int _003C_003E1__state)
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

	[Header("--- UI Objects ---")]
	[SerializeField]
	private GameObject _answerPanel;

	[SerializeField]
	private GameObject _questionPanel;

	[SerializeField]
	private GameObject _trackPanel;

	[Header("--- Question Text ---")]
	[SerializeField]
	private Text _firstNumber;

	[SerializeField]
	private Text _secondNumber;

	[SerializeField]
	private Text _answerNumber;

	[SerializeField]
	private Text _operatorSign;

	[SerializeField]
	private Text _wrongNumber;

	[SerializeField]
	[Header("--- Answers Text ---")]
	private Text _answerText1;

	[SerializeField]
	private Text _answerText2;

	[SerializeField]
	private Text _answerText3;

	[SerializeField]
	private Text _rightAnswerDummy;

	[SerializeField]
	[Header("--- Animators ---")]
	private Animator _answerAnim;

	[SerializeField]
	private Animator _questionAnim;

	[Header("--- GameObjects ---")]
	[SerializeField]
	private GameObject _timer;

	[SerializeField]
	private GameObject _countDown;

	[SerializeField]
	private Animator _countDownAnim;

	[SerializeField]
	private List<Sprite> _playerFaces;

	private string _rightAnswer;

	private int _numberOfQuestionAppeared;

	private Color32 _defaultAnswerNumberColor;

	private Color32 _correctAnswerNumberColor;

	public static Action OnCountDownComplete;

	public static Action OnRightAnswer;

	public static Action OnWrongAnswer;

	public static Action OnRaceEnd;

	private float _durationOfCountDownAnimation;

	private float _waitTimeForFirstQuestionAppear;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGameStart(CharacterType characterType)
	{
	}

	[IteratorStateMachine(typeof(_003CStartCountdownAfterPanelMove_003Ed__31))]
	private IEnumerator StartCountdownAfterPanelMove()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetEquation_003Ed__32))]
	private IEnumerator SetEquation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetAnswers_003Ed__33))]
	private IEnumerator SetAnswers()
	{
		return null;
	}

	public void OnAnswerButtonClick(Transform btn)
	{
	}

	[IteratorStateMachine(typeof(_003CShowTimerOnPlayerIdle_003Ed__35))]
	private IEnumerator ShowTimerOnPlayerIdle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHandleAnswer_003Ed__36))]
	private IEnumerator HandleAnswer(Transform btn)
	{
		return null;
	}
}
