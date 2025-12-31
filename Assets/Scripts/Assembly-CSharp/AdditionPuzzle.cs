using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AdditionPuzzle : Singleton<AdditionPuzzle>
{
	[CompilerGenerated]
	private sealed class _003CHintForOptionsCoroutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private WaitForSeconds _003CPointOneDelay_003E5__3;

		private string _003CcurrentResultVal_003E5__4;

		private int _003Cj_003E5__5;

		private int _003Ci_003E5__6;

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
		public _003CHintForOptionsCoroutine_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CLoadData_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

		private WaitForSeconds _003CPointOneTwo_003E5__2;

		private WaitForSeconds _003CPointFour_003E5__3;

		private int _003Ccount_003E5__4;

		private int _003Ccount1_003E5__5;

		private int _003Ci_003E5__6;

		private List<string> _003CForPreviousValues_003E5__7;

		private AudioClip _003CSolvePuzzle_003E5__8;

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
		public _003CLoadData_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

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
		public _003COnClose_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003COnComplete_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

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
		public _003COnComplete_003Ed__66(int _003C_003E1__state)
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
	private sealed class _003COnCompleteCountAnim_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

		private WaitForSeconds _003CPointEightFive_003E5__2;

		private int _003Ci_003E5__3;

		private Transform _003CNumberObject_003E5__4;

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
		public _003COnCompleteCountAnim_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

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
		public _003COnNextButtonClick_003Ed__72(int _003C_003E1__state)
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
	private sealed class _003COnReplayMode_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

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
		public _003COnReplayMode_003Ed__65(int _003C_003E1__state)
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
	private sealed class _003COncompleteWave_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdditionPuzzle _003C_003E4__this;

		private WaitForSeconds _003CPointOneEight_003E5__2;

		private int _003Ci_003E5__3;

		private Transform _003CNumberObject_003E5__4;

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
		public _003COncompleteWave_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

		public AdditionPuzzle _003C_003E4__this;

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
		public _003CPlayClip_003Ed__73(int _003C_003E1__state)
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

	public static int MotivatedScreenCount;

	public static int MatchNumberCompletionCount;

	private int RandomNumberStartRange;

	private int RandomNumberEndRange;

	private int targetFingerId;

	private int FirstObject;

	private int SecondObject;

	private int Result;

	private int MatchCount;

	private int RetryCount;

	private int ZeroCount;

	public GameObject CloseSlider;

	public GameObject GameplayBg;

	private List<GameObject> UpperChild;

	private List<string> ListOfNumber;

	private Transform Toy_Trail;

	private Transform Confitti;

	private Transform LowerPanel;

	private bool ismousepress;

	private bool IsReplay;

	private bool IsObjectMatch;

	private bool IsZeroGenerated;

	private bool IsGameLoadFirst;

	private GameObject ReplayBtn;

	private GameObject closeBtn;

	private GameObject HelpObject;

	private GameObject ResultRing;

	private GameObject SelectedTouchPiece;

	private GameObject NxtBtn;

	private GameObject GoodJob;

	private GameObject GiftCollect;

	private GameObject StickerCollection;

	private GameObject MainPanel;

	private GameObject StampCollection;

	private GameObject Lion;

	private GameObject UpperPanel;

	private GameObject ButterFly;

	[Header("GamePlaySound :")]
	public AudioClip ObjectPopSound;

	public AudioClip ObjectPickSound;

	public AudioClip RightMatchSound;

	public AudioClip WrongMatchSound;

	public AudioClip BoardParticleSound;

	public AudioClip audienceSound;

	public AudioClip EnglishMe;

	public AudioClip InHindi;

	private WaitForSeconds PointTwoDelay;

	private WaitForSeconds PointFiveDelay;

	private AudioSource thisAudioSource;

	private Vector2 ObjectDragPosition;

	private string SpecialScreeName;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnRingHelp()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadData_003Ed__51))]
	private IEnumerator LoadData()
	{
		return null;
	}

	private void HintForOptions()
	{
	}

	[IteratorStateMachine(typeof(_003CHintForOptionsCoroutine_003Ed__53))]
	private IEnumerator HintForOptionsCoroutine()
	{
		return null;
	}

	private void ButterflyAnim()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__56))]
	public IEnumerator OnClose()
	{
		return null;
	}

	private void OnTouchStart(Vector3 position, int fingerid)
	{
	}

	public void PlayObjectSound(string number, bool IsBothAudioPlay = false)
	{
	}

	private GameObject ReturnClickedObjects(RaycastHit2D hit, Vector3 _touch, int fingerId)
	{
		return null;
	}

	private void OnTouchDrag(Vector3 position, int fingerid)
	{
	}

	private void OnTouchEnd(int fingerid)
	{
	}

	private void AnimationComplted(GameObject animationSelectedTouchPiece)
	{
	}

	public void OnReplay()
	{
	}

	[IteratorStateMachine(typeof(_003COnReplayMode_003Ed__65))]
	private IEnumerator OnReplayMode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnComplete_003Ed__66))]
	private IEnumerator OnComplete()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnCompleteCountAnim_003Ed__67))]
	private IEnumerator OnCompleteCountAnim()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COncompleteWave_003Ed__68))]
	private IEnumerator OncompleteWave()
	{
		return null;
	}

	public void OnNext()
	{
	}

	public void OnNextScreen()
	{
	}

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__72))]
	private IEnumerator OnNextButtonClick()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__73))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.None)
	{
		return null;
	}

	public void OnWrongMatch()
	{
	}

	private void OnApplicationFocus(bool IsFocus)
	{
	}

	public void ApplicationPause(bool isFous)
	{
	}
}
