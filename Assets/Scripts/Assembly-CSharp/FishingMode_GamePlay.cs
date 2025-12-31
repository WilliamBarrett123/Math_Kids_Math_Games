using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FishingMode_GamePlay : MonoBehaviour
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
	private sealed class _003CLoadData_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingMode_GamePlay _003C_003E4__this;

		private List<float> _003ClstDelayValues_003E5__2;

		private List<float> _003ClstDelayValues_temp_003E5__3;

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
		public _003CLoadData_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003COnClose_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingMode_GamePlay _003C_003E4__this;

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
		public _003COnClose_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003COnComplete_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003COnComplete_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingMode_GamePlay _003C_003E4__this;

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
		public _003COnNextButtonClick_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public SoundType _soundtype;

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
		public _003CPlayClip_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CSetActivePartilce_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CSetActivePartilce_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CSetCurrentQuestion_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public FishingMode_GamePlay _003C_003E4__this;

		public bool isFromLoad;

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
		public _003CSetCurrentQuestion_003Ed__33(int _003C_003E1__state)
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

	public static FishingMode_GamePlay Instance;

	public FishingModeContent objContent;

	private AudioSource thisAudioSource;

	private GameObject NxtBtn;

	private GameObject closeBtn;

	private GameObject GameplayBg;

	private GameObject HelpObject;

	public GameObject CloseSlider;

	private int RandomNumberStartRange;

	private int RandomNumberEndRange;

	private List<EquationDetail> lstEquations;

	private int firstNum;

	private int secondNum;

	private int RetryCount;

	public int RightAnswer;

	public int QuestionCompleteCount;

	public int localQuestionCount;

	private string currentOperator;

	public bool isFunLevel;

	public List<int> lstWrongAnsPosibilities;

	public AssetBundle modeBundle;

	public DolphinState _dolphinState;

	private float _oldMatchWidthHeight;

	private bool isLoadFromAsset;

	private float boatStopPos;

	public GameObject HelpContent;

	public AudioClip GetaudioClip => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public AudioClip LoadAudioFromAssetBundle(string _audioClip)
	{
		return null;
	}

	public void OnTempButtonClick(string button)
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

	[IteratorStateMachine(typeof(_003CLoadData_003Ed__32))]
	private IEnumerator LoadData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetCurrentQuestion_003Ed__33))]
	public IEnumerator SetCurrentQuestion(float delay, bool isFromLoad = false)
	{
		return null;
	}

	private void GenerateEquation(List<int> lstNumbers1, List<int> lstNumbers2, int NoOfEqu)
	{
	}

	private void GetCurrentQuestion()
	{
	}

	public void GenerateWrongPossibilities()
	{
	}

	public void HandHelp(Transform HintTargetObject)
	{
	}

	public void StopHelp()
	{
	}

	[IteratorStateMachine(typeof(_003COnComplete_003Ed__40))]
	private IEnumerator OnComplete()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnClose_003Ed__41))]
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

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__44))]
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

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__47))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.sfx)
	{
		return null;
	}

	public void PlayDolphinJumpSounds(float Delay = 0f, bool IsUpSound = false)
	{
	}

	public void PlayDolphinSounds(float Delay = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003CSetActivePartilce_003Ed__52))]
	public IEnumerator SetActivePartilce(float Delay = 0f)
	{
		return null;
	}

	private AudioClip[] RoateArray(AudioClip[] Audioarray)
	{
		return null;
	}
}
