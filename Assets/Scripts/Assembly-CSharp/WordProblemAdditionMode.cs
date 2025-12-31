using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WordProblemAdditionMode : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAutoMoveAfterDelay_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003CAutoMoveAfterDelay_003Ed__90(int _003C_003E1__state)
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
	private sealed class _003CCompleteHandAnimation_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

		public bool isCalledForHint;

		public bool isFromStart;

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
		public _003CCompleteHandAnimation_003Ed__108(int _003C_003E1__state)
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
	private sealed class _003CHandleCorrectAnswer_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

		public int correctButtonIndex;

		private float _003CAnimationDuration_003E5__2;

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
		public _003CHandleCorrectAnswer_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CLoadData_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003CLoadData_003Ed__86(int _003C_003E1__state)
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
	private sealed class _003CObjectEntryAnimation_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003CObjectEntryAnimation_003Ed__73(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003COnClose_003Ed__87(int _003C_003E1__state)
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
	private sealed class _003COnCompletion_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003COnCompletion_003Ed__84(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003COnNextButtonClick_003Ed__85(int _003C_003E1__state)
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

		public WordProblemAdditionMode _003C_003E4__this;

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
	private sealed class _003CPlayHandAnimation_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

		public bool isFromStart;

		public bool isCalledForHint;

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
		public _003CPlayHandAnimation_003Ed__107(int _003C_003E1__state)
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
	private sealed class _003CPlayObjectAnimatonOnClick_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

		public float waitTime;

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
		public _003CPlayObjectAnimatonOnClick_003Ed__78(int _003C_003E1__state)
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

		public float delay;

		public GameObject particleObject;

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
	private sealed class _003CQuestionPanelSet_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003CQuestionPanelSet_003Ed__74(int _003C_003E1__state)
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
	private sealed class _003CSetLionAnimation_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003CSetLionAnimation_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CSetUpAnswerButtons_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

		private int _003CcorrectAnswer_003E5__2;

		private List<int> _003CwrongAnswers_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CSetUpAnswerButtons_003Ed__71(int _003C_003E1__state)
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
	private sealed class _003CStartAnimationSequence_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003CStartAnimationSequence_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CplayObjectAnimation_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WordProblemAdditionMode _003C_003E4__this;

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
		public _003CplayObjectAnimation_003Ed__80(int _003C_003E1__state)
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

	public static WordProblemAdditionMode Instance;

	[Header("UI References")]
	public Transform objectClickableButton;

	public Text questionText;

	public Button[] answerButtons;

	public GameObject handHintAnimation;

	public GameObject ObjectsParent;

	public GameObject MainPanel;

	[Header("Game Settings")]
	public int currentLevel;

	public int questionsPerLevel;

	public float autoNextDelay;

	public float hintDelay;

	public float lucasAnimationDuration;

	[Header("Number Generation Settings")]
	public int randomNumberStartRange;

	public int randomNumberEndRange;

	public int zeroCount;

	public int levelCount;

	public int correctButtonIndex;

	public bool isZeroGenerated;

	public bool NextLevel;

	[Header("Object Cycling")]
	private List<ObjectData> availableObjects;

	private int currentObjectIndex;

	private const string USED_OBJECTS_KEY = "WordProblemUsedObjects";

	private const string USED_OBJECTS_KEY_Subtraction = "WordProblemUsedObjectsSubtraction";

	[Header("Collections")]
	public List<ObjectData> objectDatabaseList;

	private AnswerData AnswerDataBase;

	private ObjectData currentObject;

	[Header("Animation Clips")]
	public AudioClip ItemEntrySound;

	public AudioClip ItemTouchSound;

	public AudioClip ExitAllObjectSound;

	public AudioClip LevelCompleteMusic;

	public AudioClip ConfettiCheersAndClap;

	public AudioClip ConfettiBlast;

	public AudioClip EntryTextPopup;

	public AudioClip NumberButtonEntry;

	public AudioClip RightAnswer;

	public AudioClip WrongAnswer;

	private GameObject currentObjectInstance;

	[SerializeField]
	private GameObject NxtBtn;

	[SerializeField]
	private GameObject closeBtn;

	public GameObject GameplayBg;

	public GameObject Level_1_Object;

	public GameObject Level_2_Object;

	public GameObject Level_1_Object_Sub;

	public GameObject Level_2_Object_Sub;

	private GameObject Lion;

	private Coroutine autoMoveCoroutine;

	private bool isAnswerSelected;

	private bool QuestionPopUpAnimateFirstTime;

	private AudioSource audioSource;

	[Header("Answer Button Position Storage")]
	private Vector3[] originalAnswerButtonPositions;

	[Header("Hand Help")]
	[SerializeField]
	private GameObject _handHelp;

	[SerializeField]
	[Header("Hand Help")]
	private GameObject TempQuestionChangeButton;

	private bool isHandHelpActive;

	private Coroutine helpCoroutine;

	private bool firstLaunch;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnLocaleChanged(Locale obj)
	{
	}

	public void OnTempQuestionChangeButtonClick()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void InitializeObjectCycling()
	{
	}

	private void LoadUsedObjects()
	{
	}

	private void CreateAvailableObjectsList()
	{
	}

	private void ShuffleAvailableObjects()
	{
	}

	private void SaveUsedObject(string objectKey)
	{
	}

	private void ResetUsedObjects()
	{
	}

	private void InitializeGame()
	{
	}

	private void PlayInstruction()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimationSequence_003Ed__69))]
	private IEnumerator StartAnimationSequence()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetLionAnimation_003Ed__70))]
	public IEnumerator SetLionAnimation(string animationName, float delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetUpAnswerButtons_003Ed__71))]
	private IEnumerator SetUpAnswerButtons()
	{
		return null;
	}

	private void SetupNumberGenerationRanges()
	{
	}

	[IteratorStateMachine(typeof(_003CObjectEntryAnimation_003Ed__73))]
	private IEnumerator ObjectEntryAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CQuestionPanelSet_003Ed__74))]
	private IEnumerator QuestionPanelSet()
	{
		return null;
	}

	public void OnAnswerButtonClick(int buttonIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CHandleCorrectAnswer_003Ed__76))]
	private IEnumerator HandleCorrectAnswer(int correctButtonIndex)
	{
		return null;
	}

	public void OnObjectButtonClick()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayObjectAnimatonOnClick_003Ed__78))]
	private IEnumerator PlayObjectAnimatonOnClick(float waitTime)
	{
		return null;
	}

	private void PlaySpecificObjectAnimation(string animationName)
	{
	}

	[IteratorStateMachine(typeof(_003CplayObjectAnimation_003Ed__80))]
	private IEnumerator playObjectAnimation()
	{
		return null;
	}

	private void HandleWrongAnswer(int wrongButtonIndex)
	{
	}

	public void OnNextScreen()
	{
	}

	public void OnNext()
	{
	}

	[IteratorStateMachine(typeof(_003COnCompletion_003Ed__84))]
	private IEnumerator OnCompletion()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__85))]
	private IEnumerator OnNextButtonClick()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadData_003Ed__86))]
	private IEnumerator LoadData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__87))]
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

	[IteratorStateMachine(typeof(_003CAutoMoveAfterDelay_003Ed__90))]
	private IEnumerator AutoMoveAfterDelay()
	{
		return null;
	}

	private void SetupHelpSystem()
	{
	}

	private void GenerateAnswerForLevel()
	{
	}

	private AnswerData GenerateSingleAnswerForAddition()
	{
		return null;
	}

	private AnswerData GenerateSingleAnswerForSubtraction()
	{
		return null;
	}

	private ObjectData GetNextObject()
	{
		return null;
	}

	private string GetRandomObjectKey()
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

	public float GetCurrentAnimationLength(Animator animator)
	{
		return 0f;
	}

	private void StoreOriginalAnswerButtonPositions()
	{
	}

	private void ApplyStoredAnswerButtonPositions()
	{
	}

	public void ShowHelpAfterDelay(bool isFromStart)
	{
	}

	public void CancelHintInvoke()
	{
	}

	private void CallHint()
	{
	}

	private void CallHelp()
	{
	}

	private void CheckForHandHelp(bool isCalledForHint, bool isFromStart = false)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayHandAnimation_003Ed__107))]
	private IEnumerator PlayHandAnimation(bool isCalledForHint, bool isFromStart = false, float delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCompleteHandAnimation_003Ed__108))]
	private IEnumerator CompleteHandAnimation(bool isCalledForHint, bool isFromStart)
	{
		return null;
	}

	private void SetHandPositionForHelp()
	{
	}
}
