using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardSwappingControl : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	[Serializable]
	private class EquationDetail
	{
		public int FirstNumber;

		public int SecondNumber;

		public int AnsNumber;

		public string currentOperator;
	}

	[CompilerGenerated]
	private sealed class _003CCheckForHelp_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public CardSwappingControl _003C_003E4__this;

		private RectTransform _003ChandHelpRect_003E5__2;

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
		public _003CCheckForHelp_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CDisableAnimatorAfterDelay_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Animator animator;

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
		public _003CDisableAnimatorAfterDelay_003Ed__27(int _003C_003E1__state)
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
	private GameObject _billingScriptObject;

	[SerializeField]
	private GameObject _handHelp;

	[SerializeField]
	private GameObject _collisionArea;

	[SerializeField]
	private Animator cardAnimator;

	[SerializeField]
	private RectTransform cardRect;

	[Header("Texts")]
	[SerializeField]
	private Text _firstNumber;

	[SerializeField]
	private Text _secondNumber;

	[SerializeField]
	private Text _operatorSign;

	[SerializeField]
	private Text _answerNumber;

	[SerializeField]
	private Text _rightAnswerDummy;

	[Header("Sounds")]
	[SerializeField]
	private AudioClip _cardEntry;

	[SerializeField]
	private AudioClip _cardSwap;

	[SerializeField]
	private AudioClip _confettiSound;

	[SerializeField]
	private AudioClip _moneyMachineEntry;

	[SerializeField]
	private AudioClip _correctAnswerSound;

	[SerializeField]
	private AudioClip _wrongAnswerSound;

	[SerializeField]
	private List<AudioClip> _numberClickTone;

	[SerializeField]
	private List<Text> allBtnLst;

	private string _rightAnswer;

	private Vector3 offset;

	private Camera mainCamera;

	private bool isSwapped;

	private bool isDragging;

	private GameObject handHelpObject;

	private string userAnswer;

	private int _numberClickClipIndex;

	private int RandomNumberStartRange;

	private int RandomNumberEndRange;

	private List<EquationDetail> lstEquations;

	private List<EquationDetail> lstEquationsInGame;

	private int RightAnswer;

	private int QuestionCompleteCount;

	private string currentOperator;

	public List<int> lstWrongAnsPosibilities;

	private EquationDetail currentEquation;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckForHelp_003Ed__26))]
	private IEnumerator CheckForHelp(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDisableAnimatorAfterDelay_003Ed__27))]
	private IEnumerator DisableAnimatorAfterDelay(Animator animator, float delay)
	{
		return null;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	public void OnNumberBtnClick(Transform btn)
	{
	}

	private void PlayRightAnimation()
	{
	}

	private void PlayWrongAnimation()
	{
	}

	private void ClearAnswerText()
	{
	}

	public void OnClearButtonClick(Transform btn)
	{
	}

	private void SetEquation()
	{
	}

	private void GetCurrentQuestion()
	{
	}

	public void GenerateWrongPossibilities()
	{
	}

	private void GenerateEquation(List<int> lstNumbers1, List<int> lstNumbers2, int NoOfEqu)
	{
	}

	public List<string> GetEquation()
	{
		return null;
	}

	public List<string> GetAnswer()
	{
		return null;
	}

	private void Log(string message)
	{
	}
}
