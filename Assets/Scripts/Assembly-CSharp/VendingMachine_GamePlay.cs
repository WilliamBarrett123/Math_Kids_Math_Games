using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class VendingMachine_GamePlay : MonoBehaviour
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
	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public VendingMachine_GamePlay _003C_003E4__this;

		public GameObject cloneObj;

		internal void _003CRightClickAnimation_003Eb__0()
		{
		}

		internal void _003CRightClickAnimation_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAutoMoveObjectToTrolly_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

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
		public _003CAutoMoveObjectToTrolly_003Ed__75(int _003C_003E1__state)
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
	private sealed class _003CFillSelectImages_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isClear;

		public VendingMachine_GamePlay _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CFillSelectImages_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CHandDragCoroutin_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

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
		public _003CHandDragCoroutin_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CInitModeDetails_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

		public bool isOnlyQuestion;

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
		public _003CInitModeDetails_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

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
		public _003COnClose_003Ed__109(int _003C_003E1__state)
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
	private sealed class _003COnComplete_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003COnComplete_003Ed__108(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

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
		public _003COnNextButtonClick_003Ed__112(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

		public VendingMachine_GamePlay _003C_003E4__this;

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
		public _003CPlayClip_003Ed__115(int _003C_003E1__state)
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
	private sealed class _003CRightClickAnimation_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

		public Transform clickedObject;

		private _003C_003Ec__DisplayClass74_0 _003C_003E8__1;

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
		public _003CRightClickAnimation_003Ed__74(int _003C_003E1__state)
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
	private sealed class _003CStartNextLevel_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

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
		public _003CStartNextLevel_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003CWrongClickAnimation_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

		public Transform clickedObject;

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
		public _003CWrongClickAnimation_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CsetAnswerButtons_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isClear;

		public VendingMachine_GamePlay _003C_003E4__this;

		private List<int> _003ClstAnsOptions_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CsetAnswerButtons_003Ed__62(int _003C_003E1__state)
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
	private sealed class _003CsetQuestionButtons_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VendingMachine_GamePlay _003C_003E4__this;

		public bool isClear;

		public bool isRefill;

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
		public _003CsetQuestionButtons_003Ed__61(int _003C_003E1__state)
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

	public static VendingMachine_GamePlay Instance;

	private AudioSource thisAudioSource;

	private AudioSource lionAudioSource;

	[SerializeField]
	private Text txt_EquAnswer;

	[SerializeField]
	private Transform machine;

	[SerializeField]
	private Transform machineParent;

	[SerializeField]
	private Transform answerPanel;

	[SerializeField]
	private Transform questionPanel;

	[SerializeField]
	private Transform itemContentArea;

	[SerializeField]
	private Transform dropAreaContainer;

	[SerializeField]
	private Transform trolly;

	[SerializeField]
	private Transform trollyObjectContainer;

	[SerializeField]
	private Transform SelectedItemContainer;

	[SerializeField]
	private List<Transform> ans_Buttons;

	[SerializeField]
	private List<Text> que_Buttons;

	public List<Sprite> allItemSprites;

	public Transform draggingObject;

	public GameObject CloseSlider;

	public SkeletonGraphic _SpineLion;

	private List<Sprite> itemSprites_Local;

	private List<int> ans_SpritesIndex;

	private GameObject NxtBtn;

	private GameObject closeBtn;

	private GameObject GameplayBg;

	private GameObject HelpObject;

	private GameObject _gameplayClose;

	private int RandomNumberStartRange;

	private int RandomNumberEndRange;

	private string currentOperator;

	private List<EquationDetail> lstEquations;

	private float trollyPosLeft;

	private float trollyPosRight;

	private float trollyStopPos;

	private float machinePos;

	private int RightAnswer;

	private int firstNum;

	private int secondNum;

	private int QuestionCompleteCount;

	private int RetryCount;

	private bool isEntryCompleted;

	public GameObject Counter;

	[SerializeField]
	public GameObject _billingContainer;

	[SerializeField]
	private float _offsetPosition;

	[SerializeField]
	private float _timeForBackGroundScroll;

	[SerializeField]
	private float _timeForLucasMove;

	[SerializeField]
	private float _lucasOffset;

	[SerializeField]
	private Transform _transition2;

	[SerializeField]
	private Transform Stop;

	private string currentHelpPhase;

	public GameObject HelpContent;

	private Transform HintTargetObject;

	private Transform HintStartObject;

	private Transform imgObject;

	public AnimationCurve objectDrop;

	private List<int> lstTrollyRefPlace;

	private List<string> lstLucasIdleLastAnim;

	private List<string> lstLucasCorrectTapAnim;

	private List<string> lstLucasCorrectDragAnim;

	private List<string> lstLucasWrongAnim;

	private int idleAnimIndex_Lucas;

	private int wrongAnimIndex_Lu;

	private int motivationSoundIndex;

	private int IdelCount_Lu;

	[SerializeField]
	private AudioClip lion_say_Hi;

	[SerializeField]
	private AudioClip Claping;

	[SerializeField]
	private AudioClip Lucas_laugh;

	[SerializeField]
	private AudioClip Delicious_Lick;

	[SerializeField]
	private AudioClip Lucas_Happy_2;

	[SerializeField]
	private AudioClip Wowww;

	[SerializeField]
	private AudioClip Saying_No;

	[SerializeField]
	private AudioClip Saying_No_2;

	[SerializeField]
	private AudioClip Correct_Button_Tap;

	[SerializeField]
	private AudioClip Food_Ready_Down;

	[SerializeField]
	private AudioClip Lucas_Entry;

	[SerializeField]
	private AudioClip Lucas_Exit;

	[SerializeField]
	private AudioClip Machine_ON;

	[SerializeField]
	private AudioClip Put_basket;

	[SerializeField]
	private AudioClip Wrong_BTN;

	private List<string> lstIdleMotivationSounds;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void DeviceInfoCalc(InputDevice device, InputDeviceChange deviceChange)
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CInitModeDetails_003Ed__54))]
	private IEnumerator InitModeDetails(bool isOnlyQuestion)
	{
		return null;
	}

	private void LoadItemContainer()
	{
	}

	[IteratorStateMachine(typeof(_003CFillSelectImages_003Ed__56))]
	private IEnumerator FillSelectImages(bool isClear)
	{
		return null;
	}

	private void FillLocalSpriteList()
	{
	}

	private void chooseAnswersforGame()
	{
	}

	private Sprite getSpriteOfItem(int objectIndex)
	{
		return null;
	}

	private void GetCurrentQuestion()
	{
	}

	[IteratorStateMachine(typeof(_003CsetQuestionButtons_003Ed__61))]
	private IEnumerator setQuestionButtons(bool isRefill, bool isClear)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CsetAnswerButtons_003Ed__62))]
	private IEnumerator setAnswerButtons(bool isClear)
	{
		return null;
	}

	private void SpawnParticleForObjects(string particleName, Transform parentObj)
	{
	}

	private void HandHelp()
	{
	}

	[IteratorStateMachine(typeof(_003CHandDragCoroutin_003Ed__70))]
	private IEnumerator HandDragCoroutin()
	{
		return null;
	}

	private void StopHelp()
	{
	}

	public void OnAnswerSelection(Transform clickedObject)
	{
	}

	[IteratorStateMachine(typeof(_003CRightClickAnimation_003Ed__74))]
	private IEnumerator RightClickAnimation(Transform clickedObject)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAutoMoveObjectToTrolly_003Ed__75))]
	private IEnumerator AutoMoveObjectToTrolly()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWrongClickAnimation_003Ed__76))]
	private IEnumerator WrongClickAnimation(Transform clickedObject)
	{
		return null;
	}

	private void OnObjectTouchStartEndEvent(GameObject objDrag, bool isStart, bool isPlaceOnWrong)
	{
	}

	private void OnResultSuccessfully(GameObject objDrag, GameObject objDropOn, bool isAutoMove = false)
	{
	}

	[IteratorStateMachine(typeof(_003CStartNextLevel_003Ed__80))]
	private IEnumerator StartNextLevel()
	{
		return null;
	}

	private void LionAnimationsStartCallbacks(TrackEntry entry)
	{
	}

	private void LionAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private void PlayObjectSound(string number, bool IsBothAudioPlay = false)
	{
	}

	[IteratorStateMachine(typeof(_003COnComplete_003Ed__108))]
	private IEnumerator OnComplete()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__109))]
	public IEnumerator OnClose()
	{
		return null;
	}

	public void OnNext()
	{
	}

	public void OnNextScreen()
	{
	}

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__112))]
	private IEnumerator OnNextButtonClick()
	{
		return null;
	}

	private void OnApplicationFocus(bool IsFocus)
	{
	}

	private void OnApplicationPause(bool IsFocus)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__115))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}

	private void SetBillingMode()
	{
	}

	private void ActivateBillingScript()
	{
	}
}
