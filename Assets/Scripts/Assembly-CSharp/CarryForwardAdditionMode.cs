using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CarryForwardAdditionMode : MonoBehaviour
{
	private enum TutorStep
	{
		OnesDigit = 0,
		Carry = 1,
		TensDigit = 2,
		Complete = 3
	}

	[CompilerGenerated]
	private sealed class _003CAutoMoveAfterDelay_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CAutoMoveAfterDelay_003Ed__96(int _003C_003E1__state)
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
	private sealed class _003CCompleteHandAnimation_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CCompleteHandAnimation_003Ed__105(int _003C_003E1__state)
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
	private sealed class _003CHandleLevelCompletion_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CHandleLevelCompletion_003Ed__86(int _003C_003E1__state)
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
	private sealed class _003CInitializeGameplay_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CInitializeGameplay_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CLoadData_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CLoadData_003Ed__92(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003COnClose_003Ed__93(int _003C_003E1__state)
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
	private sealed class _003COnCompletion_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003COnCompletion_003Ed__90(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

		public float delay;

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
		public _003COnNextButtonClick_003Ed__91(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public AudioClip soundName;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CPlayClip_003Ed__97(int _003C_003E1__state)
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
	private sealed class _003CPlayHandAnimation_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

		public float delay;

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
		public _003CPlayHandAnimation_003Ed__104(int _003C_003E1__state)
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
	private sealed class _003CPlayParticleSystem_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject particleObject;

		public float delay;

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
		public _003CPlayParticleSystem_003Ed__98(int _003C_003E1__state)
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
	private sealed class _003CSetLionAnimation_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public CarryForwardAdditionMode _003C_003E4__this;

		public string animationName;

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
		public _003CSetLionAnimation_003Ed__73(int _003C_003E1__state)
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
	private sealed class _003CStartAnimationSequence_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CStartAnimationSequence_003Ed__71(int _003C_003E1__state)
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
	private sealed class _003CStepWisePlayParticleSystem_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject particleObject;

		public float delay;

		public CarryForwardAdditionMode _003C_003E4__this;

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
		public _003CStepWisePlayParticleSystem_003Ed__99(int _003C_003E1__state)
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

	public static CarryForwardAdditionMode Instance;

	[Header("UI References")]
	public Button[] answerButtons;

	public GameObject MainPanel;

	public GameObject TextPanel;

	public GameObject Box_Localized;

	public GameObject Box_UnLocalized;

	public GameObject BoxParent;

	public GameObject Level_1Parent;

	public GameObject AnswerPanel;

	public GameObject QuestionPanel;

	public GameObject pageing;

	public GameObject HelpContentParent;

	public GameObject HelpBox_localized;

	public GameObject HelpBox_unlocalized;

	public GameObject HelpTextPanel;

	[Header("Game Settings")]
	public int currentLevel;

	public int questionsPerLevel;

	public bool LevelReset;

	private bool HelpButtonClickable;

	public float autoNextDelay;

	public float hintDelay;

	[Header("Animation Clips")]
	public AudioClip LevelCompleteMusic;

	public AudioClip ConfettiCheersAndClap;

	public AudioClip ConfettiBlast;

	public AudioClip RightAnswer;

	public AudioClip WrongAnswer;

	public AudioClip ButtonIN;

	[SerializeField]
	private GameObject NxtBtn;

	[SerializeField]
	private GameObject closeBtn;

	public GameObject GameplayBg;

	private GameObject Lion;

	private Coroutine autoMoveCoroutine;

	private AudioSource audioSource;

	[SerializeField]
	[Header("Hand Help")]
	[Header("Answer Button Position Storage")]
	private GameObject _handHelp;

	private bool isHandHelpActive;

	private Coroutine helpCoroutine;

	[SerializeField]
	[Header("Question UI")]
	private Text addend1TensText;

	[SerializeField]
	private Text addend1OnesText;

	[SerializeField]
	private Text addend2TensText;

	[SerializeField]
	private Text addend2OnesText;

	[SerializeField]
	private Text resultTensText;

	[SerializeField]
	private Text resultOnesText;

	[SerializeField]
	private Text carryText;

	[SerializeField]
	[Header("Help Question UI")]
	private Text addend1TensText_Help;

	[SerializeField]
	private Text addend1OnesText_Help;

	[SerializeField]
	private Text addend2TensText_Help;

	[SerializeField]
	private Text addend2OnesText_Help;

	[SerializeField]
	private Text resultTensText_Help;

	[SerializeField]
	private Text resultOnesText_Help;

	[SerializeField]
	private Text carryText_Help;

	[Header("Digit Groups For Fading")]
	[SerializeField]
	private List<GameObject> onesPlaceTutObjects;

	[SerializeField]
	private List<GameObject> tensPlaceTutObjects;

	[SerializeField]
	private List<GameObject> onesPlaceTutObjects_Help;

	[SerializeField]
	private List<GameObject> tensPlaceTutObjects_Help;

	[Header("Particles & Effects")]
	[SerializeField]
	private GameObject confettiParticles;

	[Header("Question Generator")]
	private BaseQuestionGenerator.AddQuestionGenerator questionGenerator;

	private TutorStep currentStep;

	private BaseQuestionGenerator.AddQuestionGenerator.AddQuestion currentQuestion;

	private int tutorialQuestionIndex;

	private int correctQuestionsThisLevel;

	private bool isAwaitingCorrectAnswer;

	private int[] answerButtonValues;

	private int correctButtonIndex;

	private GameObject activeStepParticleObject;

	private ParticleSystem activeStepParticleSystem;

	private bool SupportedLanguagesForOnceTensText => false;

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

	[IteratorStateMachine(typeof(_003CInitializeGameplay_003Ed__70))]
	private IEnumerator InitializeGameplay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartAnimationSequence_003Ed__71))]
	private IEnumerator StartAnimationSequence()
	{
		return null;
	}

	private void PlayInstruction()
	{
	}

	[IteratorStateMachine(typeof(_003CSetLionAnimation_003Ed__73))]
	public IEnumerator SetLionAnimation(string animationName, float delay = 0f)
	{
		return null;
	}

	private void SetupNewQuestion()
	{
	}

	private void PopulateQuestionUI()
	{
	}

	private void SetupAnswerButtonsForCurrentStep()
	{
	}

	private List<int> GenerateOptions(int correct)
	{
		return null;
	}

	private void DistributeOptionsToButtons(List<int> options, int correct)
	{
	}

	private void StopActiveParticles()
	{
	}

	private void HandleAnswerSteps(int buttonIndex)
	{
	}

	private void OnWrongAnswerForStep(int buttonIndex)
	{
	}

	private void OnCorrectAnswerForStep(int selected)
	{
	}

	private void DisableCarryParticleAfterDelay()
	{
	}

	private void OnQuestionComplete()
	{
	}

	private void ConvertNumberToArabic(Text CurrentText)
	{
	}

	[IteratorStateMachine(typeof(_003CHandleLevelCompletion_003Ed__86))]
	private IEnumerator HandleLevelCompletion()
	{
		return null;
	}

	public void OnAnswerButtonClick(int buttonIndex)
	{
	}

	public void OnNextScreen()
	{
	}

	public void OnNext()
	{
	}

	[IteratorStateMachine(typeof(_003COnCompletion_003Ed__90))]
	private IEnumerator OnCompletion()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__91))]
	private IEnumerator OnNextButtonClick(float delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadData_003Ed__92))]
	private IEnumerator LoadData(float delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__93))]
	public IEnumerator OnClose()
	{
		return null;
	}

	private void StartAutoMoveTimer()
	{
	}

	private void StopAutoMoveTimer()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoMoveAfterDelay_003Ed__96))]
	private IEnumerator AutoMoveAfterDelay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__97))]
	private IEnumerator PlayClip(AudioClip soundName, float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayParticleSystem_003Ed__98))]
	private IEnumerator PlayParticleSystem(GameObject particleObject, float delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStepWisePlayParticleSystem_003Ed__99))]
	private IEnumerator StepWisePlayParticleSystem(GameObject particleObject, float delay = 0f)
	{
		return null;
	}

	public void ShowHelpAfterDelay(float delay)
	{
	}

	public void CancelHintInvoke()
	{
	}

	private void CallHelp()
	{
	}

	private void CheckForHandHelp()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayHandAnimation_003Ed__104))]
	private IEnumerator PlayHandAnimation(float delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCompleteHandAnimation_003Ed__105))]
	private IEnumerator CompleteHandAnimation()
	{
		return null;
	}

	private void SetHandPositionForHelp()
	{
	}

	public void ShowHelpContent(GameObject thisObject)
	{
	}

	public void CloseHelpContent(GameObject thisObject)
	{
	}
}
