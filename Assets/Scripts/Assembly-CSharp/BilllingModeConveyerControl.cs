using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class BilllingModeConveyerControl : MonoBehaviour
{
	public enum PresentAction
	{
		Billing = 0,
		Paying = 1,
		Collectbag = 2
	}

	[CompilerGenerated]
	private sealed class _003CHandDragCoroutine_003Ed__128 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BilllingModeConveyerControl _003C_003E4__this;

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
		public _003CHandDragCoroutine_003Ed__128(int _003C_003E1__state)
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
	private sealed class _003CMoveLucasToSecodStop_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BilllingModeConveyerControl _003C_003E4__this;

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
		public _003CMoveLucasToSecodStop_003Ed__114(int _003C_003E1__state)
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
	private sealed class _003CMovingLucasToLastStop_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BilllingModeConveyerControl _003C_003E4__this;

		public bool isAfterCashPayment;

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
		public _003CMovingLucasToLastStop_003Ed__118(int _003C_003E1__state)
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
	private sealed class _003CMovingLucasToOut_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BilllingModeConveyerControl _003C_003E4__this;

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
		public _003CMovingLucasToOut_003Ed__119(int _003C_003E1__state)
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
	private sealed class _003CSetLightInActive_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BilllingModeConveyerControl _003C_003E4__this;

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
		public _003CSetLightInActive_003Ed__105(int _003C_003E1__state)
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
	private sealed class _003CStart_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BilllingModeConveyerControl _003C_003E4__this;

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
		public _003CStart_003Ed__94(int _003C_003E1__state)
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

	private GameObject _lastItemOnConveyer;

	private Tweener _conveyerTween;

	private float _animDuartion;

	private DropZone _objectDropZone;

	private DropZone _moneyDropZone;

	private int _scannedItemCounter;

	private List<int> _itemsCosts;

	private Transform _currentItem;

	private bool _isItemDrop;

	private float _destAnchorPosition;

	private List<Transform> _alreadyScannedItems;

	private bool _setNoteAngle;

	private bool _setCoinOffset;

	private int _notesSortinOrder;

	private int _coinSorintgOrder;

	private AudioSource _rollerAudioSource;

	private AudioSource _lionAudioSource;

	private Vector2 _defaultNoteCoinPosition;

	private float __defaultNoteCoinRotation;

	private bool _lightInActiveCoroutineRunning;

	private GameObject _gamePlayClose;

	private int _rubyIdleCounter;

	private int _lucasIDleCounter;

	private int _lucasIdleEBCounter;

	private int _rubyIdleEBCounter;

	private int _lucasIdleSideEBCount;

	private PresentAction _lucasPresentStop;

	private string _text10;

	private string _text20;

	private string _text1;

	private string _text5;

	private string _text0;

	private float _itemOriginalScale;

	private int _newSortingOrder;

	private int _oldSortingOrder;

	private readonly string _coinsAnimName;

	private readonly string _notesAnimName;

	private Transform _objectContainer;

	private List<Transform> _wheels;

	private Ease _lineaeEase;

	private GameObject bgimage;

	[SerializeField]
	private GameObject _scannner;

	[SerializeField]
	private GameObject _scannnerLight;

	[SerializeField]
	private GameObject _objectDropZoneArea;

	[SerializeField]
	private GameObject _moneyDropZoneArea;

	[SerializeField]
	private GameObject _moneyBlock;

	[SerializeField]
	private GameObject _trolly;

	[SerializeField]
	private GameObject _bag;

	[SerializeField]
	private GameObject _bagToppp;

	[SerializeField]
	private GameObject _coinsParent;

	[SerializeField]
	private GameObject _notesParent;

	[SerializeField]
	private GameObject _dummyNotes;

	[SerializeField]
	private GameObject _dummyCoins;

	[SerializeField]
	private GameObject _billCounter;

	[SerializeField]
	private Transform _billingCounter;

	[SerializeField]
	private Transform _notesCounter;

	[SerializeField]
	private Transform _paymentSelection;

	[SerializeField]
	private Transform _cardSwappingObj;

	[SerializeField]
	private Transform _transition1;

	[SerializeField]
	private Text _currentAmountPaidText;

	[SerializeField]
	private Text _costText;

	[SerializeField]
	private Image _line;

	[SerializeField]
	private RawImage _rawImage;

	[SerializeField]
	private GameObject _yesImage;

	[SerializeField]
	private float _totalCost;

	[SerializeField]
	private float _currentAmount;

	[SerializeField]
	private int _lastNoteGivenByUser;

	[SerializeField]
	private Animator _moneyAnimationControl;

	[SerializeField]
	private AudioClip _putItemsOnTheCounter;

	[SerializeField]
	private AudioClip _plzPayMoney;

	[SerializeField]
	private AudioClip _counterCloseOpen;

	[SerializeField]
	private AudioClip _yesSound;

	[SerializeField]
	private AudioClip _objJumpGoingToBag;

	[SerializeField]
	private AudioClip _objPuInBag;

	[SerializeField]
	private AudioClip _coinDrop;

	[SerializeField]
	private AudioClip _quickScan;

	[SerializeField]
	private AudioClip _addMoney;

	[SerializeField]
	private AudioClip _rubyNoNo;

	[SerializeField]
	private AudioClip _bagAddInCart;

	[SerializeField]
	private AudioClip _noteDrop;

	[SerializeField]
	private AudioClip _rubyThankU;

	[SerializeField]
	private AudioClip _lucasByeBye;

	[SerializeField]
	private AudioClip _howWouldYou;

	public SkeletonGraphic RubySpine;

	public SkeletonGraphic LucasSpine;

	public Text CounterTopNote;

	public Text AnimatorTopNote;

	public LocaleText_uGUI[] LocaleTextUGUIs;

	public float NoteZValue;

	public float RandomNess;

	public int Vibrate;

	public float VibrateTime;

	[SerializeField]
	private float _delayTime;

	private float _zoomValue;

	private float _topMoveValue;

	public GameObject HelpContent;

	private Transform _hintStartObject;

	private Transform imgObject;

	[SerializeField]
	private Transform _hintTargetObject;

	[SerializeField]
	private Transform _hintCoin;

	private bool isHandHelp;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__94))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 vector)
	{
	}

	private void OnObjectTouchStartEndEvent(GameObject objDrag, bool isStart, bool isPlaceOnWrong)
	{
	}

	private void OnResultSuccessfully(GameObject _drggedObejct, GameObject _dropOnObejct, bool arg3)
	{
	}

	private void RubyAnimationCompleteCallbacks(TrackEntry trackEntry)
	{
	}

	private void LucasAnimationCompleteCallbacks(TrackEntry trackEntry)
	{
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
	}

	public void OnTriggerStay2D(Collider2D col)
	{
	}

	public void OnTriggerExit2D(Collider2D col)
	{
	}

	private void MoveAlongParabola(Vector2 startPoint, Vector2 endPoint, Transform obJect, bool IsbagMoving = false)
	{
	}

	[IteratorStateMachine(typeof(_003CSetLightInActive_003Ed__105))]
	private IEnumerator SetLightInActive()
	{
		return null;
	}

	private void SetObjectsDraggable()
	{
	}

	private void SetCostText()
	{
	}

	private void SetLocalizedTextForNotes()
	{
	}

	private string Converttext(string textId)
	{
		return null;
	}

	private int CurrentItemCost(Transform temp)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CMoveLucasToSecodStop_003Ed__114))]
	private IEnumerator MoveLucasToSecodStop()
	{
		return null;
	}

	public void OnCashPaymentSelection(Transform btn)
	{
	}

	public void OnCardPaymentSelection(Transform btn)
	{
	}

	public void MoveLucasLast()
	{
	}

	[IteratorStateMachine(typeof(_003CMovingLucasToLastStop_003Ed__118))]
	private IEnumerator MovingLucasToLastStop(bool isAfterCashPayment)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMovingLucasToOut_003Ed__119))]
	private IEnumerator MovingLucasToOut()
	{
		return null;
	}

	private void SetTransition()
	{
	}

	private void HandHelp()
	{
	}

	[IteratorStateMachine(typeof(_003CHandDragCoroutine_003Ed__128))]
	private IEnumerator HandDragCoroutine()
	{
		return null;
	}

	private void StopHelp()
	{
	}

	private bool IsLucasInIdleCondition(string currentAnimationName)
	{
		return false;
	}

	private bool IsRubyInIdleCondition(string currentAnimationName)
	{
		return false;
	}

	private bool IsEnglishSound()
	{
		return false;
	}

	private bool IsRtlLang()
	{
		return false;
	}

	private void SetWheelsMovement(bool isMove = true)
	{
	}

	private Transform SetHintStartObject()
	{
		return null;
	}
}
