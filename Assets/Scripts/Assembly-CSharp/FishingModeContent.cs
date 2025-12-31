using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Spine;
using Spine.Unity;
using UnityEngine;

public class FishingModeContent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public bool hookreached;

		public FishingModeContent _003C_003E4__this;

		public bool isCollectAnimCompleted;

		public Transform clickedObject;

		internal bool _003COnSpecialFishClick_003Eb__4()
		{
			return false;
		}

		internal void _003COnSpecialFishClick_003Eb__6()
		{
		}

		internal bool _003COnSpecialFishClick_003Eb__7()
		{
			return false;
		}

		internal void _003COnSpecialFishClick_003Eb__9()
		{
		}

		internal bool _003COnSpecialFishClick_003Eb__10()
		{
			return false;
		}

		internal void _003COnSpecialFishClick_003Eb__12()
		{
		}

		internal void _003COnSpecialFishClick_003Eb__13()
		{
		}

		internal void _003COnSpecialFishClick_003Eb__16()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public FishingModeContent _003C_003E4__this;

		public Transform clickedObject;

		public float directionVal;

		public bool isCollectAnimCompleted;

		public TweenCallback _003C_003E9__4;

		public TweenCallback _003C_003E9__3;

		internal void _003CRightClickAnimation_003Eb__1()
		{
		}

		internal void _003CRightClickAnimation_003Eb__3()
		{
		}

		internal void _003CRightClickAnimation_003Eb__4()
		{
		}

		internal bool _003CRightClickAnimation_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGenerateDarkFish_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingModeContent _003C_003E4__this;

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
		public _003CGenerateDarkFish_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CGenerateFish_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingModeContent _003C_003E4__this;

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
		public _003CGenerateFish_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CGenerateSpecialFish_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FishingModeContent _003C_003E4__this;

		private List<string> _003CexistingSpecialFish_003E5__2;

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
		public _003CGenerateSpecialFish_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003COnDolphinButtinClick_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingModeContent _003C_003E4__this;

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
		public _003COnDolphinButtinClick_003Ed__82(int _003C_003E1__state)
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
	private sealed class _003COnFunLevelCompleted_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingModeContent _003C_003E4__this;

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
		public _003COnFunLevelCompleted_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003COnSpecialFishClick_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingModeContent _003C_003E4__this;

		public Transform clickedObject;

		public FishController.FishType fishType;

		private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

		private Vector3 _003CclickPos_003E5__2;

		private Transform _003CParent_003E5__3;

		private Vector3 _003Cscale_003E5__4;

		private Vector3 _003Crotation_003E5__5;

		private float _003Cmidpoint_003E5__6;

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
		public _003COnSpecialFishClick_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public FishingModeContent _003C_003E4__this;

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
		public _003CPlayClip_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CRightClickAnimation_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingModeContent _003C_003E4__this;

		public Transform clickedObject;

		private _003C_003Ec__DisplayClass50_0 _003C_003E8__1;

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
		public _003CRightClickAnimation_003Ed__50(int _003C_003E1__state)
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

	public static FishingModeContent Instance;

	public Transform FishPanel;

	public Transform BB_Fish;

	public Transform Popup_Question;

	public Transform BB_Aquarium;

	public Transform boneHook;

	public Transform StickEnd;

	public Transform Splash_pufferFish;

	public List<GameObject> lstFishesPrefab;

	public List<GameObject> lstDarkFishesPrefab;

	public List<GameObject> lstSpecialFishesPrefab;

	public List<GameObject> lstBubbles;

	public Transform QuestionContent;

	[SerializeField]
	private AudioClip Correct_Button_Tap;

	[SerializeField]
	private AudioClip Wrong_BTN;

	[SerializeField]
	private GameObject fishTapParticle;

	[SerializeField]
	private GameObject aquarium_Splash;

	[SerializeField]
	private AudioSource AudioRopeLoop;

	public SkeletonGraphic _SpineLion;

	[NonSerialized]
	public float screenWidth;

	private int funLevelInterVal;

	public List<float> lstRandomPosY;

	private List<float> lstRandomPosY_temp;

	[NonSerialized]
	public List<float> lstDelayValues;

	private List<float> lstDelayValues_temp;

	private int fishIndex;

	private int specFishIndex;

	private List<int> lstFishCanvasLayers;

	private List<int> lstFishCanvasLayers_Temp;

	private List<int> lstRightAnsInterval;

	private DateTime lastFishGenerateTime;

	private float fishSpawnTimeDiff;

	public List<GameObject> lstDarkFishesPrefab_Temp;

	private Vector3 hookDefaultPos;

	private Transform currentClickedobject;

	private Vector2 BoatPosition;

	public bool isAddHandHelp;

	[SerializeField]
	private Transform ProgressPanel;

	[SerializeField]
	private Transform filImage;

	[SerializeField]
	private Transform fillObject;

	[SerializeField]
	private Transform ProgressAquarium;

	private List<string> lstLucasIdleLastAnim;

	private int idleAnimIndex_Lucas;

	private int IdelCount_Lu;

	public string currentAnimName;

	public List<string> Animationames;

	[SerializeField]
	private bool SetDanceR;

	public float Normalizedoffset;

	public GameObject JumpSplashParFisrt;

	public GameObject JumpSplashParSecond;

	[SerializeField]
	public AudioClip JumpUP;

	[SerializeField]
	public AudioClip JumpDown;

	[SerializeField]
	public AudioClip Rotate2Clip;

	[SerializeField]
	public AudioClip DanceClip;

	[SerializeField]
	public AudioClip[] JumphappyClips;

	[SerializeField]
	public AudioClip[] Rotate1FastGoingClips;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ManageBubbleParticle()
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateFish_003Ed__37))]
	public IEnumerator GenerateFish()
	{
		return null;
	}

	private int GetCurrentTrackCanvasLayers(float yPos)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CGenerateDarkFish_003Ed__40))]
	public IEnumerator GenerateDarkFish(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGenerateSpecialFish_003Ed__41))]
	public IEnumerator GenerateSpecialFish(float delay)
	{
		return null;
	}

	private float getRandomYpos()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003COnSpecialFishClick_003Ed__46))]
	public IEnumerator OnSpecialFishClick(FishController.FishType fishType, Transform clickedObject)
	{
		return null;
	}

	private void SetPosition(float s)
	{
	}

	private void PlayLoopAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CRightClickAnimation_003Ed__50))]
	public IEnumerator RightClickAnimation(Transform clickedObject)
	{
		return null;
	}

	private void FollowClickedObject(float value)
	{
	}

	[IteratorStateMachine(typeof(_003COnFunLevelCompleted_003Ed__52))]
	private IEnumerator OnFunLevelCompleted()
	{
		return null;
	}

	private void UpdateProgressBar()
	{
	}

	private void ResetProgressBar()
	{
	}

	public void WrongClickAnimation(Transform clickedObject)
	{
	}

	private void LionAnimationsStartCallbacks(TrackEntry entry)
	{
	}

	private void LionAnimationsEventCallbacks(TrackEntry trackEntry, Event e)
	{
	}

	private void BoatPushAnim()
	{
	}

	private void LionAnimationsCompleteCallbacks(TrackEntry entry)
	{
	}

	private GameObject SpawnParticleForObjects(string particleName, Transform parentObj, GameObject particleObject = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__69))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}

	public void SetDolphinAnimation(Animator Dolphinanimator, DolphinState dolphinState = DolphinState.Swim)
	{
	}

	[IteratorStateMachine(typeof(_003COnDolphinButtinClick_003Ed__82))]
	public IEnumerator OnDolphinButtinClick(Transform clickedObject)
	{
		return null;
	}
}
