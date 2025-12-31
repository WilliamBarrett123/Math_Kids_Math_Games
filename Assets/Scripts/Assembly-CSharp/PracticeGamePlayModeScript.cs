using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PracticeGamePlayModeScript : Singleton<PracticeGamePlayModeScript>
{
	private class EquationDetail
	{
		public int FirstNumber;

		public int SecondNumber;

		public GameObject Ans;

		public GameObject QuestionmarObj;

		public EquationDetail(int firstNum, int SecondNum, GameObject AnsObj, GameObject QuestionmarObj)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003COnAnswerPanelScaleDownAnimation_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003COnAnswerPanelScaleDownAnimation_003Ed__74(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003COnClose_003Ed__95(int _003C_003E1__state)
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
	private sealed class _003COnCompleteCountAnim_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003COnCompleteCountAnim_003Ed__86(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003COnNextButtonClick_003Ed__92(int _003C_003E1__state)
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

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
	private sealed class _003CactiveNextQuestionObject_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003CactiveNextQuestionObject_003Ed__61(int _003C_003E1__state)
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
	private sealed class _003CbackEffectAnimShow_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

		public int questionIndex;

		public GameObject parentObj;

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
		public _003CbackEffectAnimShow_003Ed__75(int _003C_003E1__state)
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
	private sealed class _003CcompleteRoundSuccess_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003CcompleteRoundSuccess_003Ed__83(int _003C_003E1__state)
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
	private sealed class _003CdisplayBoardLine_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003CdisplayBoardLine_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CdisplayBottomAnsObjectsAnimation_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isMatchValue;

		public PracticeGamePlayModeScript _003C_003E4__this;

		private WaitForSeconds _003CPointOneTwoDelay_003E5__2;

		private WaitForSeconds _003CPointZeroTwoDelay_003E5__3;

		private int _003Ci_003E5__4;

		private Transform _003CdisplyObj1_003E5__5;

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
		public _003CdisplayBottomAnsObjectsAnimation_003Ed__81(int _003C_003E1__state)
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
	private sealed class _003CdisplayQuestionObjAnim_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

		private WaitForSeconds _003CPointOneTwoDelay_003E5__2;

		private int _003Ci_003E5__3;

		private int _003Cj_003E5__4;

		private Transform _003CdisplyObjI_003E5__5;

		private Transform _003CdisplyObjJ_003E5__6;

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
		public _003CdisplayQuestionObjAnim_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003ChandHelp_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003ChandHelp_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CloadGame_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003CloadGame_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CplayWronkAnsAnimation_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003CplayWronkAnsAnimation_003Ed__73(int _003C_003E1__state)
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
	private sealed class _003CsetData_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003CsetData_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CshowHintHand_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PracticeGamePlayModeScript _003C_003E4__this;

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
		public _003CshowHintHand_003Ed__63(int _003C_003E1__state)
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

	private float SoundDelay;

	private List<EquationDetail> lstEquations;

	private List<int> lstOfBottomAns;

	private int minNum;

	private int maxNum;

	private int targetFingerId;

	private int totalAnsFilled;

	private int MotivatedScreenCount;

	private int firstAnsHintIndex;

	[SerializeField]
	private GameObject QuestionPanal;

	[SerializeField]
	private GameObject OptionsPanel;

	private GameObject SelectedAnsOptionPiece;

	private GameObject GameplayBg;

	private GameObject closeBtn;

	private GameObject NxtBtn;

	private GameObject Lion;

	private GameObject currentUsedQuestionPanal;

	private GameObject MainPanel;

	private GameObject GoodJob;

	private GameObject StampCollection;

	private GameObject GiftCollect;

	private GameObject StickerCollection;

	private GameObject ButterFly;

	private GameObject HelpObject;

	private GameObject boardCenterLine;

	private Transform Toy_Trail;

	private bool isAdditionMode;

	private bool ismousepress;

	private bool isHelpShow;

	private string GameModeName;

	[SerializeField]
	private Sprite ansBg;

	private GameObject[] arrOfQuestions;

	private int[] arrAdvanceModePlaces;

	private Color32 whiteColor;

	private Color32 greenColor;

	private Color32 YellowColor;

	private Color32 DisableColor;

	private WaitForSeconds PointFiveDelay;

	private WaitForSeconds PointTwoDelay;

	private WaitForSeconds PointSevenDelay;

	private WaitForSeconds PointTenDelay;

	private Transform Confitti;

	[Header("GamePlaySound :")]
	public AudioClip ObjectPopSound;

	public AudioClip ObjectPickSound;

	public AudioClip RightMatchSound;

	public AudioClip WrongMatchSound;

	public AudioClip BoardParticleSound;

	public AudioClip audienceSound;

	private bool isTallDevice;

	private bool isHideRabbit;

	private AudioSource thisAudioSource;

	private Vector3 HandhelpPos;

	private Vector2 ObjectDragPosition;

	private int RetryCount;

	private string SpecialScreeName;

	private GameObject LucasBalloonPop;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CloadGame_003Ed__53))]
	private IEnumerator loadGame()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void addQuestionInArray()
	{
	}

	[IteratorStateMachine(typeof(_003CsetData_003Ed__56))]
	private IEnumerator setData()
	{
		return null;
	}

	private void hideRabbitForTallDevice()
	{
	}

	private void GenerateEquationAndSet()
	{
	}

	private void setColorEnable(Transform currentQue)
	{
	}

	private void setColorDisable(Transform currentQue)
	{
	}

	[IteratorStateMachine(typeof(_003CactiveNextQuestionObject_003Ed__61))]
	private IEnumerator activeNextQuestionObject()
	{
		return null;
	}

	private void setAnsOptionPanel()
	{
	}

	[IteratorStateMachine(typeof(_003CshowHintHand_003Ed__63))]
	private IEnumerator showHintHand()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003ChandHelp_003Ed__64))]
	private IEnumerator handHelp()
	{
		return null;
	}

	public void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void Update()
	{
	}

	private void OnTouchStart(Vector3 position, int fingerid)
	{
	}

	private void OnTouchDrag(Vector3 position, int fingerid)
	{
	}

	private void OnTouchEnd(Vector3 position, int fingerid)
	{
	}

	[IteratorStateMachine(typeof(_003CplayWronkAnsAnimation_003Ed__73))]
	private IEnumerator playWronkAnsAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnAnswerPanelScaleDownAnimation_003Ed__74))]
	private IEnumerator OnAnswerPanelScaleDownAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CbackEffectAnimShow_003Ed__75))]
	private IEnumerator backEffectAnimShow(GameObject parentObj, int questionIndex)
	{
		return null;
	}

	private void ResetRectTransform(GameObject thisObject)
	{
	}

	private void DisableRectTransform(GameObject thisObject)
	{
	}

	private void DisableAllQuestions()
	{
	}

	[IteratorStateMachine(typeof(_003CdisplayBoardLine_003Ed__79))]
	private IEnumerator displayBoardLine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CdisplayQuestionObjAnim_003Ed__80))]
	private IEnumerator displayQuestionObjAnim()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CdisplayBottomAnsObjectsAnimation_003Ed__81))]
	private IEnumerator displayBottomAnsObjectsAnimation(bool isMatchValue)
	{
		return null;
	}

	private void resetBottomAnsPanel()
	{
	}

	[IteratorStateMachine(typeof(_003CcompleteRoundSuccess_003Ed__83))]
	private IEnumerator completeRoundSuccess()
	{
		return null;
	}

	private void setprefrence()
	{
	}

	private void checkHelpShowOrNot()
	{
	}

	[IteratorStateMachine(typeof(_003COnCompleteCountAnim_003Ed__86))]
	private IEnumerator OnCompleteCountAnim()
	{
		return null;
	}

	private void setArrRandom()
	{
	}

	private void suffalBottomAnsList()
	{
	}

	public void OnNext()
	{
	}

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__92))]
	private IEnumerator OnNextButtonClick()
	{
		return null;
	}

	private void ButterflyAnim()
	{
	}

	private void ShowAlphabets()
	{
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__95))]
	public IEnumerator OnClose()
	{
		return null;
	}

	public void PlayObjectSound(int number, bool IsBothAudioPlay = false)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__97))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}
}
