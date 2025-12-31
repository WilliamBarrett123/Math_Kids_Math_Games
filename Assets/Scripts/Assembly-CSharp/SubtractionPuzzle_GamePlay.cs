using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SubtractionPuzzle_GamePlay : Singleton<SubtractionPuzzle_GamePlay>
{
	[CompilerGenerated]
	private sealed class _003CHintForOptionsCoroutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

		private string _003CcurrentResultVal_003E5__2;

		private int _003Ccount_003E5__3;

		private WaitForSeconds _003CPointOneDelay_003E5__4;

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

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

		private int _003Ci_003E5__2;

		private List<string> _003CForPreviousValues_003E5__3;

		private AudioClip _003CSolvePuzzle_003E5__4;

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
	private sealed class _003COnClose_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

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
		public _003COnClose_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003COnComplete_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

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
		public _003COnComplete_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003COnCompleteCountAnim_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

		private int _003Ci_003E5__2;

		private Transform _003CNumberObject_003E5__3;

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
		public _003COnCompleteCountAnim_003Ed__65(int _003C_003E1__state)
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

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

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
	private sealed class _003COnPlayDoubleSound_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

		private int _003Ci_003E5__2;

		private Transform _003CNumberObject_003E5__3;

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
		public _003COnPlayDoubleSound_003Ed__66(int _003C_003E1__state)
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
	private sealed class _003COnReplayMode_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

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
		public _003COnReplayMode_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003COnRightSetPiece_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

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
		public _003COnRightSetPiece_003Ed__63(int _003C_003E1__state)
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
	private sealed class _003COncompleteWave_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

		private int _003Ci_003E5__2;

		private Transform _003CNumberObject_003E5__3;

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
		public _003COncompleteWave_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

		public SubtractionPuzzle_GamePlay _003C_003E4__this;

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
		public _003CPlayClip_003Ed__76(int _003C_003E1__state)
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

	private GameObject Lion;

	private GameObject ButterFly;

	public GameObject CloseSlider;

	private GameObject TargetObjectParent;

	private GameObject NxtBtn;

	private GameObject ReplayBtn;

	private GameObject closeBtn;

	private GameObject GameplayBg;

	private GameObject HelpObject;

	private GameObject ResultRing;

	private GameObject MainPanel;

	private GameObject SelectedTouchPiece;

	private GameObject GoodJob;

	private GameObject StampCollection;

	private GameObject GiftCollect;

	private GameObject StickerCollection;

	private int SubPuzzleNumberCompletionCount;

	private int RandomNumberStartRange;

	private int RandomNumberEndRange;

	private int FirstRandom_Number;

	private int SecondRandom_Number;

	private int Result;

	private int ZeroCount;

	private List<string> ListOfValues;

	private List<GameObject> UpperChild;

	private Transform UpperPanel;

	private Transform LowerPanel;

	private Vector3 oldposition;

	private bool ismousepress;

	private bool IsReplay;

	private bool IsObjectMatch;

	private bool IsZeroGenerated;

	private bool IsGameLoadFirst;

	private int targetFingerId;

	private int MatchCount;

	private int RetryCount;

	public static int MotivatedScreenCount;

	private Transform Toy_Trail;

	private Transform Confitti;

	[Header("GamePlaySound :")]
	public AudioClip ObjectPopSound;

	public AudioClip ObjectPickSound;

	public AudioClip RightMatchSound;

	public AudioClip WrongMatchSound;

	public AudioClip BoardParticleSound;

	public AudioClip audienceSound;

	public AudioClip EnglishMe;

	public AudioClip InHindi;

	private List<SumDetails> lstSumDetails;

	private AudioSource thisAudioSource;

	private Vector2 ObjectDragPosition;

	private string SpecialScreeName;

	private void OnEnable()
	{
	}

	private void Start()
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

	private void OnRingHelp()
	{
	}

	private void Update()
	{
	}

	private void OnTouchStart(Vector3 position, int fingerid)
	{
	}

	private GameObject ReturnClickedObjects(RaycastHit2D hit, Vector3 _touch, int fingerId)
	{
		return null;
	}

	private void PlayObjectSound(string number, bool IsBothAudioPlay = false)
	{
	}

	private void OnTouchDrag(Vector3 position, int fingerid)
	{
	}

	private void OnTouchEnd(int fingerid)
	{
	}

	[IteratorStateMachine(typeof(_003COnRightSetPiece_003Ed__63))]
	private IEnumerator OnRightSetPiece()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnComplete_003Ed__64))]
	private IEnumerator OnComplete()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnCompleteCountAnim_003Ed__65))]
	private IEnumerator OnCompleteCountAnim()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnPlayDoubleSound_003Ed__66))]
	private IEnumerator OnPlayDoubleSound()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COncompleteWave_003Ed__67))]
	private IEnumerator OncompleteWave()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__68))]
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

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__72))]
	private IEnumerator OnNextButtonClick()
	{
		return null;
	}

	public void OnWrongMatch()
	{
	}

	private void OnApplicationFocus(bool IsFocus)
	{
	}

	private void OnApplicationPause(bool IsFocus)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__76))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}

	public void OnReplay()
	{
	}

	[IteratorStateMachine(typeof(_003COnReplayMode_003Ed__78))]
	private IEnumerator OnReplayMode()
	{
		return null;
	}
}
