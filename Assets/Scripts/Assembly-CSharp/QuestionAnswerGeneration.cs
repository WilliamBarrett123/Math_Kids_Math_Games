using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class QuestionAnswerGeneration : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAfterDelayReset_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestionAnswerGeneration _003C_003E4__this;

		public bool skipfirstDealy;

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
		public _003CAfterDelayReset_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CAfterDelayResetFirstPartOnly_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestionAnswerGeneration _003C_003E4__this;

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
		public _003CAfterDelayResetFirstPartOnly_003Ed__33(int _003C_003E1__state)
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

	public static QuestionAnswerGeneration instance;

	private AudioSource audioSource;

	public bool helpAvailable;

	private bool fristQuestion10;

	private List<int> questionList;

	private int rangeStart;

	private int rangeEnd;

	[SerializeField]
	private Text textQuesiton;

	public static int currentQuestion;

	public List<Text> answersText;

	public List<int> answerList;

	public static int currentCombination;

	private string combinationString;

	private List<int> combiantionnumber;

	public int correctAnsCount;

	public bool combinationReset;

	[SerializeField]
	private Transform numberAnimation;

	[SerializeField]
	private AudioClip make;

	[SerializeField]
	private Text TopPanel;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Init()
	{
	}

	private void QuestioHelper()
	{
	}

	private List<int> GenerateRandomQuestions()
	{
		return null;
	}

	public void SetQuestion(int x)
	{
	}

	public void SetAnswers()
	{
	}

	private List<int> GenerateFirstAnswerList(int x)
	{
		return null;
	}

	public void ModifyList(int number = -1)
	{
	}

	public int PenguinListHelper(int number = -1)
	{
		return 0;
	}

	public bool ValidAnswer(int number)
	{
		return false;
	}

	private void StopAllCalcs()
	{
	}

	private void ResetTopPanel()
	{
	}

	public void Resetter()
	{
	}

	[IteratorStateMachine(typeof(_003CAfterDelayReset_003Ed__32))]
	private IEnumerator AfterDelayReset(bool skipfirstDealy = true)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAfterDelayResetFirstPartOnly_003Ed__33))]
	private IEnumerator AfterDelayResetFirstPartOnly(bool skipfirstDealy = true)
	{
		return null;
	}
}
