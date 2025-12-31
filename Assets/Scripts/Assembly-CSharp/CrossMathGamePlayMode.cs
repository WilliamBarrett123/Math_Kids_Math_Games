using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CrossMathGamePlayMode : MonoBehaviour
{
	[Serializable]
	public class keyboardAnsType_Details_FunMath
	{
		public int index;

		public GameObject obj;

		public string currentPlaceAnswer;

		public string enterValue;

		public int rowIndex;

		public int currentRowindex;

		public keyboardAnsType_Details_FunMath(int _index, GameObject _obj, string _currentAns, string _enterVal)
		{
		}

		public keyboardAnsType_Details_FunMath()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckForGameplayHelp_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CCheckForGameplayHelp_003Ed__83(int _003C_003E1__state)
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
	private sealed class _003CCheckTiming_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool is1SttimeSet;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CCheckTiming_003Ed__84(int _003C_003E1__state)
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
	private sealed class _003CCorrectAns_choicesAndKeyboard_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CCorrectAns_choicesAndKeyboard_003Ed__96(int _003C_003E1__state)
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
	private sealed class _003CGenerateGridBlocks_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CGenerateGridBlocks_003Ed__63(int _003C_003E1__state)
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
	private sealed class _003CIenu_setQuestionAndOpion_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float WaitTime;

		public bool isUpdateEquation;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CIenu_setQuestionAndOpion_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CLoadData_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CLoadData_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003COnClose_003Ed__105(int _003C_003E1__state)
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
	private sealed class _003COnNextPress_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003COnNextPress_003Ed__113(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

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
		public _003CPlayClip_003Ed__94(int _003C_003E1__state)
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
	private sealed class _003CScaleDownAnimation_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CScaleDownAnimation_003Ed__97(int _003C_003E1__state)
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
	private sealed class _003CWrongAns_choicesAndKeyboard_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrossMathGamePlayMode _003C_003E4__this;

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
		public _003CWrongAns_choicesAndKeyboard_003Ed__98(int _003C_003E1__state)
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

	public static CrossMathGamePlayMode Instance;

	[SerializeField]
	private Transform TopPanel;

	[SerializeField]
	public GameObject option4Digit;

	[SerializeField]
	public GameObject optionKeyboard;

	[SerializeField]
	public GameObject QuestionContainer;

	[SerializeField]
	public GameObject btnQuestionOptions;

	public bool is4OptionOn;

	private bool isOnceAnsClick;

	public int totalQuestions;

	public string currentRunningAns;

	public int totalQuestionOptionCount;

	private int currentRunningAnsPlaceForBackSpace;

	private int QuestionCompleteCount;

	private string ansTypeStr;

	public List<keyboardAnsType_Details_FunMath> lstOfKeyboardEnterPlaceDetails;

	private List<GameObject> lstOfAnsOption;

	private AudioSource currentsource;

	public AudioClip right;

	public AudioClip wrong;

	private List<GameObject> UnderlineObjLst;

	private List<GameObject> UnderlineObjLstForCurrentAnim;

	public Text temptext;

	private string SelectedDifficulty;

	private int CurrentOptionShowCount;

	public GameObject GameplayBg;

	public List<int> lstprimeNumbers;

	[SerializeField]
	private GameObject cloneBlock;

	[SerializeField]
	private GameObject cloneQuestionsGrid;

	[SerializeField]
	private GameObject selectedBlock;

	public GameObject QuestionsGrid;

	public GameObject QuestionsGridTutorial;

	public GameObject HandHelpContent;

	private int GridSize_X;

	private int GridSize_Y;

	public List<GridInfo> lstgridBlocks;

	public List<clsBODMAS> lstAllOperators;

	public List<clsBODMAS> lstCurrentLevelOperators;

	private List<float> lstNonPrime;

	private List<float> lstNumbers;

	private List<float> lstDivisionPossibilitiesNos;

	private int RangeStart;

	private int RangeEnd;

	private int maxNumberOfQuestion;

	public List<EquationDetail> lstEquations;

	public List<GridInfo> lstAnswerBlocks;

	[SerializeField]
	private Sprite imgEmpty;

	[SerializeField]
	private Sprite imgDigit;

	[SerializeField]
	private Sprite imgCorrect;

	[SerializeField]
	private Sprite imgSelected;

	public GridInfo currentGridInfo;

	private Vector2 gridCellSize;

	private float cellSpecing;

	private float currentLevelCount;

	private float intervalForLessQuestion;

	private float counterForExcludeMulDiv;

	private bool isExcludeMulDivGiven;

	private bool isCaptureSS;

	private int ssNumberCount;

	[SerializeField]
	private Transform questionPanel;

	private bool isBreakAutoGenerateLoop;

	public List<GridInfo> lstEquationBlocks;

	private int tempBreak;

	private int operatorIndex;

	private bool isHighlightedNumber;

	[SerializeField]
	private Animator handHelpAnimator;

	private GameObject ClickedObj;

	[SerializeField]
	private Text compText;

	private Transform Confitti;

	private GameObject MainPanel;

	private GameObject StampCollection;

	private GameObject Lion;

	private GameObject closeBtn;

	private GameObject NxtBtn;

	private WaitForSeconds PointFiveDelay;

	[SerializeField]
	private Sprite correctSprite;

	[SerializeField]
	private Sprite WrongSprite;

	[SerializeField]
	private Sprite DefaultSprite;

	private Color32 colorCorrect;

	private Color32 colorDefault;

	private Color32 colorWrong;

	private GameObject spriteObj;

	private Color32 colorCorrectTxt;

	private Color32 colorWrongTxt;

	private Color32 colorDefaultTxt;

	public int currentTapButtonIndex;

	public static event Action<bool> onCurrentAnsTypeChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void SetDifficultiesData()
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateGridBlocks_003Ed__63))]
	private IEnumerator GenerateGridBlocks()
	{
		return null;
	}

	private void SetGridInCenterOfBoard()
	{
	}

	private List<GridInfo> GetGridBlocksForEquation1()
	{
		return null;
	}

	public bool isOperatorSignOrNumber(string val, bool isCheckForOperator)
	{
		return false;
	}

	private GridInfo getGridBlockFromList(int rowId, int colId)
	{
		return null;
	}

	private List<string> GenerateQuestions(string existingData = "", string tempName = "")
	{
		return null;
	}

	private bool isValidExistingData(string existingData = "")
	{
		return false;
	}

	public void OnQuestionBlockClick(Transform thisTransform)
	{
	}

	private void UpdateCurrentEquation(GridBlockData objGridBlock = null)
	{
	}

	private void SetWrongAnsKeyboardValues()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadData_003Ed__78))]
	private IEnumerator LoadData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIenu_setQuestionAndOpion_003Ed__79))]
	private IEnumerator Ienu_setQuestionAndOpion(float WaitTime = 0f, bool isUpdateEquation = true)
	{
		return null;
	}

	private List<string> FloatListToStringListConvert(List<float> myList)
	{
		return null;
	}

	private void setQuestionAndOpion()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckForGameplayHelp_003Ed__83))]
	private IEnumerator CheckForGameplayHelp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckTiming_003Ed__84))]
	private IEnumerator CheckTiming(bool is1SttimeSet)
	{
		return null;
	}

	private void updatePos(float widhtVal, float heighttVal)
	{
	}

	public void OnAnsOptionClcik(GameObject obj)
	{
	}

	public void OnHelpButtonClick(Transform thisTransform)
	{
	}

	private void checkAns(string currentAns, GameObject fourOptionObj, bool isTimerComplete = false)
	{
	}

	private void killAnimationforUnderline()
	{
	}

	private void PlayObjectSound(string number)
	{
	}

	public void PlaySound(string _number, bool IsBothAudioPlay = false)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__94))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.None)
	{
		return null;
	}

	private void ShowResultScreen()
	{
	}

	[IteratorStateMachine(typeof(_003CCorrectAns_choicesAndKeyboard_003Ed__96))]
	private IEnumerator CorrectAns_choicesAndKeyboard()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScaleDownAnimation_003Ed__97))]
	private IEnumerator ScaleDownAnimation(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWrongAns_choicesAndKeyboard_003Ed__98))]
	private IEnumerator WrongAns_choicesAndKeyboard()
	{
		return null;
	}

	public int CalculateBODMASEquation(string equationString)
	{
		return 0;
	}

	private void wrongAnsColorSet()
	{
	}

	private void correctAnsColorSet()
	{
	}

	private void resetAnsColor()
	{
	}

	public void changeOptionmode()
	{
	}

	private void setChangeOption()
	{
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__105))]
	public IEnumerator OnClose()
	{
		return null;
	}

	public void OnNext()
	{
	}

	[IteratorStateMachine(typeof(_003COnNextPress_003Ed__113))]
	private IEnumerator OnNextPress()
	{
		return null;
	}

	public void setBottomAnsPosition(GameObject ContainerObj, string containtStr, float widhtVal, float heighttVal)
	{
	}

	public void resetSprite(GameObject obj = null)
	{
	}

	private void defaultSpriteSet()
	{
	}

	public void SetWrongSprite(GameObject obj, bool isResetAfterDelay = true, float delay = 0.5f)
	{
	}

	public void SetCorrectAnsSprite(GameObject obj, bool isResetAfterDelay = true, float delay = 0.5f)
	{
	}

	public void SetCorrectColorOnTxt(GameObject obj)
	{
	}

	public void SetWrongColorOnTxt(GameObject obj)
	{
	}

	public void SetDefaultColorOnTxt(GameObject obj, List<byte> lstColorCodes = null)
	{
	}

	public static string ListToStringConvert(List<string> lstNew, char seperator)
	{
		return null;
	}

	public void sendEventForSign(bool isHighlightedNumber)
	{
	}

	public static List<string> StringToListConvert(string str, char seperator, char seperatorNested = '0')
	{
		return null;
	}
}
