using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CarMode_Gameplay : MonoBehaviour
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
	private sealed class _003COnClose_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003COnClose_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

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
		public _003CPlayClip_003Ed__38(int _003C_003E1__state)
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

	public static CarMode_Gameplay Instance;

	[SerializeField]
	private AudioSource _audioSource;

	public float PlayerScreenInTime;

	[NonSerialized]
	public float CarsDestinationPoint;

	private bool _isLoadFromAsset;

	private AssetBundle _modeBundle;

	private CarModeContent _objContent;

	private int RandomNumberStartRange;

	private int RandomNumberEndRange;

	private List<EquationDetail> lstEquations;

	private List<EquationDetail> lstEquationsInGame;

	private int RightAnswer;

	private int QuestionCompleteCount;

	private string currentOperator;

	public List<int> lstWrongAnsPosibilities;

	private EquationDetail currentEquation;

	private GameObject NxtBtn;

	private GameObject closeBtn;

	private GameObject GameplayBg;

	private GameObject GamePlayClose;

	public bool IsSelectionPopupOpen;

	public static Action OnNextClick;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnRaceEnd()
	{
	}

	public void AutoNext()
	{
	}

	public void OnNext()
	{
	}

	private void OnCountDownComplete()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 temp)
	{
	}

	public void SetCurrentQuestion()
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

	[IteratorStateMachine(typeof(_003COnClose_003Ed__37))]
	public IEnumerator OnClose()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__38))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}
}
