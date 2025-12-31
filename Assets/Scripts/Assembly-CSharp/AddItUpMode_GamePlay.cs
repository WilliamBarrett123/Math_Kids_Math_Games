using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AddItUpMode_GamePlay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public AddItUpMode_GamePlay _003C_003E4__this;

		public RectTransform bubbleRect;

		internal void _003CEnableHeartBalloon_003Eb__0()
		{
		}

		internal void _003CEnableHeartBalloon_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public float animationDuration;

		public Ease inEase;
	}

	[CompilerGenerated]
	private sealed class _003CAnimateGridTopToBottom_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

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
		public _003CAnimateGridTopToBottom_003Ed__66(int _003C_003E1__state)
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
	private sealed class _003CCheckForGameplayHelp_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

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
		public _003CCheckForGameplayHelp_003Ed__75(int _003C_003E1__state)
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
	private sealed class _003CCheckRegenerateAnswer_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

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
		public _003CCheckRegenerateAnswer_003Ed__94(int _003C_003E1__state)
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
	private sealed class _003CEnableBubble_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

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
		public _003CEnableBubble_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CEnableHeartBalloon_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

		private _003C_003Ec__DisplayClass68_0 _003C_003E8__1;

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
		public _003CEnableHeartBalloon_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003CGenerateBlocksLists_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

		private int _003CspriteCount_003E5__2;

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
		public _003CGenerateBlocksLists_003Ed__65(int _003C_003E1__state)
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
	private sealed class _003CIdleUserGameplayHelp_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

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
		public _003CIdleUserGameplayHelp_003Ed__77(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

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
		public _003COnClose_003Ed__98(int _003C_003E1__state)
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
	private sealed class _003COnCompleteCountAnim_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpMode_GamePlay _003C_003E4__this;

		private int _003Ci_003E5__2;

		private int _003Cj_003E5__3;

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
		public _003COnCompleteCountAnim_003Ed__95(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

		public AddItUpMode_GamePlay _003C_003E4__this;

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
		public _003CPlayClip_003Ed__100(int _003C_003E1__state)
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
	private sealed class _003CShockwaveColumnAnimation_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float animationDuration;

		public List<int> blockIds;

		public List<int> columnIds;

		public AddItUpMode_GamePlay _003C_003E4__this;

		private _003C_003Ec__DisplayClass92_0 _003C_003E8__1;

		private List<Transform> _003CallColumns_003E5__2;

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
		public _003CShockwaveColumnAnimation_003Ed__92(int _003C_003E1__state)
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

	public static AddItUpMode_GamePlay Instance;

	[SerializeField]
	private GameObject HandHelpContent;

	[SerializeField]
	private List<GameObject> BlocksList;

	[SerializeField]
	private List<GameObject> BlocksList_temp;

	[SerializeField]
	private Transform QuestionContent;

	[SerializeField]
	private GameObject MainContent;

	[SerializeField]
	private RectTransform _stage;

	[SerializeField]
	private RectTransform _questionBlock;

	[SerializeField]
	private Animator handHelpAnimator;

	[SerializeField]
	private Text SumText;

	[SerializeField]
	private Text BubbleTargetSumText;

	[SerializeField]
	private Text HeartBalloonTargetSumText;

	[SerializeField]
	private GameObject _blockBlastPrefab;

	[SerializeField]
	private GameObject _confettiObject;

	[SerializeField]
	private GameObject _bubbleSpawnParticleObject;

	private Text textTargetSum;

	private int TargetSumRange;

	private int CurrentSum;

	private int TargetSum;

	private GameObject GameplayBg;

	private GameObject NxtBtn;

	private GameObject closeBtn;

	private Transform Confitti;

	private AudioSource thisAudioSource;

	private WaitForSeconds PointTwoDelay;

	private bool isHeartBalloon;

	[SerializeField]
	private List<Sprite> BlocksSprite;

	[NonSerialized]
	private Color32 OrangeColor;

	[NonSerialized]
	private Color32 RedColor;

	[NonSerialized]
	private Color32 PinkColor;

	[NonSerialized]
	private Color32 PurpleColor;

	[NonSerialized]
	private Color32 GreenColor;

	[NonSerialized]
	private Color32 BlueColor;

	private List<string> LionRightAnimations;

	private List<string> LionWrongAnimations;

	[SerializeField]
	[Header("Prefabs")]
	[Space(10f)]
	private GameObject BubbleMain;

	[SerializeField]
	private GameObject BubbleMainChangeParticleObject;

	[SerializeField]
	private GameObject _bubbleBlastParticleObj;

	[SerializeField]
	private GameObject HeartBalloonMain;

	[SerializeField]
	private GameObject HeartBalloonMainChangeParticleObject;

	[SerializeField]
	private GameObject _balloonBlastParticleObj;

	[Header("Audio Clips")]
	[SerializeField]
	[Space(10f)]
	private AudioClip DelectOnSecondTap;

	[SerializeField]
	private AudioClip NumberHexaClick;

	[SerializeField]
	private AudioClip EntryHexaNumber;

	[SerializeField]
	private AudioClip HintNumberHighlight;

	[SerializeField]
	private AudioClip LetsMakeTheNumber;

	[SerializeField]
	private AudioClip LucasNBubble;

	[SerializeField]
	private AudioClip NumberHexaBlockPop;

	[SerializeField]
	private AudioClip TaregtBubblePop;

	[SerializeField]
	private AudioClip TargetHeartBalloonBlast;

	[SerializeField]
	private AudioClip TargetHeartBalloonEntry;

	[SerializeField]
	private AudioClip TargetNumberChange;

	[SerializeField]
	private AudioClip Woow;

	[SerializeField]
	private AudioClip WrongNumber;

	private RectTransform _lionRect;

	private Vector3 _lionPosition;

	[Range(0f, 1f)]
	private float probability1;

	[Range(0f, 1f)]
	private float probability2;

	[Range(0f, 1f)]
	private float probability3;

	private int randomValue;

	private List<int> blocksListValue;

	private int RightAnswerCount;

	private int lastRandomCount;

	private List<string> blockBlastList;

	[SerializeField]
	private List<Vector2> DestinationPosition;

	private List<int> columnIds;

	private List<int> blockIds;

	private float shockWaveStrength;

	public Ease _ease;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionEvent(Vector2 _temp)
	{
	}

	private void Start()
	{
	}

	private void SetLion()
	{
	}

	private void SetData()
	{
	}

	private void BlocksListFill()
	{
	}

	private void ResetBlockColor()
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateBlocksLists_003Ed__65))]
	private IEnumerator GenerateBlocksLists()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateGridTopToBottom_003Ed__66))]
	private IEnumerator AnimateGridTopToBottom(float rowDelay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEnableBubble_003Ed__67))]
	private IEnumerator EnableBubble()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEnableHeartBalloon_003Ed__68))]
	private IEnumerator EnableHeartBalloon()
	{
		return null;
	}

	private int SelectNumberBasedOnProbability()
	{
		return 0;
	}

	private void AnswerGenerate()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckForGameplayHelp_003Ed__75))]
	private IEnumerator CheckForGameplayHelp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIdleUserGameplayHelp_003Ed__77))]
	private IEnumerator IdleUserGameplayHelp()
	{
		return null;
	}

	private List<List<int>> FindSubsetsThatSumToTarget(List<int> nums, int target)
	{
		return null;
	}

	private void Backtrack(List<int> nums, int index, int remaining, List<int> current, List<List<int>> result)
	{
	}

	public void OnClickBlock(Transform transform)
	{
	}

	private void AddNumberToSum(int number)
	{
	}

	private void PlayMotivationSound(float delay = 0f)
	{
	}

	private void TriggerBubbleBalloonAnimation(string triggerName, bool isRevert = false)
	{
	}

	private void ResetTargetSumUpdateParticle()
	{
	}

	[IteratorStateMachine(typeof(_003CShockwaveColumnAnimation_003Ed__92))]
	public IEnumerator ShockwaveColumnAnimation(List<int> blockIds, List<int> columnIds, float animationDuration = 0.25f, float shakeIntensity = 20f, int shakeVibrato = 50, float shakeRandomness = 90f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckRegenerateAnswer_003Ed__94))]
	private IEnumerator CheckRegenerateAnswer()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnCompleteCountAnim_003Ed__95))]
	private IEnumerator OnCompleteCountAnim()
	{
		return null;
	}

	public void OnNext()
	{
	}

	public void NextOnAutoPopBalloon()
	{
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__98))]
	public IEnumerator OnClose()
	{
		return null;
	}

	public void PlayObjectSound(int number, bool IsBothAudioPlay = false)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__100))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}
}
