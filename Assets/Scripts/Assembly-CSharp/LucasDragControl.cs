using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(DragActivity), typeof(SkeletonGraphic))]
public class LucasDragControl : CharacterDragControl, ICharacter
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public Transform Hand2;

		public Transform Hand1;

		public Transform LucashandHelp;

		internal void _003CNewCCHandHelp_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CNewCCHandHelp_003Ed__149 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LucasDragControl _003C_003E4__this;

		private _003C_003Ec__DisplayClass149_0 _003C_003E8__1;

		private Vector2 _003CHandHelpPosition_003E5__2;

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
		public _003CNewCCHandHelp_003Ed__149(int _003C_003E1__state)
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
	private sealed class _003CSetRubyAnimationforIntro_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CSetRubyAnimationforIntro_003Ed__152(int _003C_003E1__state)
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

	public CharacterPrefix characterPrefix;

	public static LucasDragControl Instance;

	private Status LucasStatus;

	private SkeletonGraphic LucasSkeleton;

	private bool _isthrown;

	private float _anglerRad;

	private float _xVeloCity;

	private float _yVlocity;

	private Vector2 _newVelocity;

	private float _startTime;

	private Vector2 _scrollVelocity;

	[SerializeField]
	private RectTransform _layer1RectTransform;

	[SerializeField]
	private RectTransform _layer2RectTransform;

	[SerializeField]
	private RectTransform _layer4RectTransform;

	[SerializeField]
	private RectTransform _bglayerRectTransform;

	private Vector2 Startpos;

	private RectTransform _ContentRectTransform;

	private Rigidbody2D rb;

	[SerializeField]
	public GameObject ArrowRight;

	[SerializeField]
	public GameObject ArrowLeft;

	private RectTransform ArrowLeftRecTrasnfrom;

	private RectTransform ArrowRightRectTranform;

	private Camera _CameraMain;

	private float lastLucasActivityTime;

	private float WalkingLucasStartTime;

	private float Width;

	private float ScrollSpeed;

	private float SpeedofLucas;

	private int AnimCounter;

	private Vector3 ScreenBounds;

	private Vector3 MovePosition;

	private Vector2 offset;

	private bool isHappyWalking;

	private bool iSintroAnimation;

	private bool LucasisThrown;

	private bool _isDragging;

	private bool SetLucasIdle;

	private bool SwicthingLucasAnimation;

	private bool ISLucasdrag;

	public static bool isLucasPerformingActivity;

	private BoxCollider2D Layer1Collider;

	private BoxCollider2D Layer2Collider;

	private BoxCollider2D Layer4Collider;

	private GameObject Container;

	private GameObject TummyorFace;

	private Vector2 pointerposition;

	public Vector3[] _viewportworldCorners;

	[SerializeField]
	private GameObject Horse;

	[SerializeField]
	private GameObject _Car;

	[SerializeField]
	private GameObject _helpTarget;

	[SerializeField]
	private GameObject Whitetransition;

	[SerializeField]
	private Transform _Room;

	[SerializeField]
	private Transform _Viewport;

	[SerializeField]
	private Transform _Content;

	[SerializeField]
	private Transform SkateRampForHandhelp;

	[SerializeField]
	private GameObject RightEnd;

	[SerializeField]
	private GameObject LeftEnd;

	[SerializeField]
	private GameObject Up;

	[SerializeField]
	private GameObject Tummy;

	[SerializeField]
	private GameObject Face;

	[SerializeField]
	private RectTransform viewportTransform;

	public static bool LucasEnteredInGarden;

	[SerializeField]
	private float fadeDuration;

	private float originalVolume;

	private RectTransform LucasrectTransform;

	private bool isHighlight;

	private GameObject HighlightedGameobject;

	private Tween MyTween;

	private Collider2D HighlightedCollider;

	private float WidthofViewport;

	private Tweener LeftArrowTween;

	private Tweener RightArrowTween;

	private float RightArrowAnchospos;

	private float leftArrowAnchorpos;

	private bool ISWalking;

	public static bool IsLucasInScreen;

	private bool ISEnterIngarden;

	private bool handHelpCalled;

	private GameObject HandHelp;

	public CharacterName characterName => default(CharacterName);

	public SkeletonGraphic CharcterSkeleton => null;

	public RectTransform CharRectTransform => null;

	public Transform CharacterTransform => null;

	public BoxCollider2D CharcterCollider => null;

	public Status CurrentStatus
	{
		get
		{
			return default(Status);
		}
		set
		{
		}
	}

	public float LastActivityTime => 0f;

	public float WalkingStartTime => 0f;

	public bool CharacterIdleAnimBool
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SwitchAnimationBool
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SetRayCastStatus
	{
		set
		{
		}
	}

	public bool IsCharacterCanDrag
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsCharacterDragging => false;

	public Transform GetViewPortTransform => null;

	public Transform GetContentTransform => null;

	public event EventHandler<CharacterEventArgs> CharcterTriggerStatus
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

	public event EventHandler<Transform> SetCharacterBeginDragStatus
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

	public event EventHandler SetCharacterEndDragStatus
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

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public override void OnPointerDown(PointerEventData data)
	{
	}

	public override void OnBeginDrag(PointerEventData data)
	{
	}

	public override void OnDrag(PointerEventData data)
	{
	}

	public override void OnPointerUp(PointerEventData data)
	{
	}

	public override void OnEndDrag(PointerEventData data)
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 Pos)
	{
	}

	private void UpdateViewPortCornesrWithDelay()
	{
	}

	private void UpdateArrowPosition()
	{
	}

	private bool CheckItsIgnoreBoard(GameObject Raycastobjet)
	{
		return false;
	}

	private void SetColliders(bool IsignoreLucasPosition = false)
	{
	}

	private void SetLucasAccrodingTolayer(bool IsignoreLucasPosition = false)
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	private void OnTriggerStay2D(Collider2D col)
	{
	}

	private void OnTriggerExit2D(Collider2D col)
	{
	}

	private void SetSpecificAnimationOfLucas(GameObject thisGameobject)
	{
	}

	protected override void HandleBackGroundScroll()
	{
	}

	protected override void HandleCharacterIdleMovement()
	{
	}

	protected override void HandleArrowUI()
	{
	}

	protected override void CheckingInput()
	{
	}

	protected override void CheckingInputMouse()
	{
	}

	public void ArrowButtonClicked()
	{
	}

	private void SetArrowPositionOnOrientationChange()
	{
	}

	private void SetAnchorPosForOneSideNotch()
	{
	}

	public void LucasEventCallBack(TrackEntry trackEntry, Event eventdata)
	{
	}

	public void LucasEvent_Complete_CallBack(TrackEntry trackEntry)
	{
	}

	private void StopLucasSlidingOnIntro()
	{
	}

	[IteratorStateMachine(typeof(_003CNewCCHandHelp_003Ed__149))]
	private IEnumerator NewCCHandHelp()
	{
		return null;
	}

	public void KIllIntroHandHelp()
	{
	}

	private void LucasIntroIntoGarden()
	{
	}

	[IteratorStateMachine(typeof(_003CSetRubyAnimationforIntro_003Ed__152))]
	private IEnumerator SetRubyAnimationforIntro()
	{
		return null;
	}

	private void SetActiveContent()
	{
	}

	private void SetLuCasIdleState()
	{
	}

	private void SetAltrnateParent(bool IsContent = false)
	{
	}

	private void SetWalkingAccodingTopos(float Size)
	{
	}

	private void OnWalkingLeft()
	{
	}

	private void OnWalkingRight()
	{
	}

	public void BallonCompleteAnimation()
	{
	}

	private bool IsCharcterIdleOrIdleWalking()
	{
		return false;
	}

	public override void SetSpeciFicAnimation(GameObject OnDropItem)
	{
	}

	public override void HighLightingtheObject(GameObject thisGameobject, bool ISKILL = false)
	{
	}

	public void CheckCharacterCurrentStatus(Status currentstatus)
	{
	}

	public void UpdateChacterTimeStatus()
	{
	}

	public Transform LayerObject(ActivityLayer activityLayer)
	{
		return null;
	}
}
