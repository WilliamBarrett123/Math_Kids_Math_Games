using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MainContent_SudokuMode : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEnableOptions_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainContent_SudokuMode _003C_003E4__this;

		public List<int> options;

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
		public _003CEnableOptions_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CPlayClip_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CPlayClipOnShot_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public AudioClip audioClip;

		public MainContent_SudokuMode _003C_003E4__this;

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
		public _003CPlayClipOnShot_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CSelectSameCellAfterWrong_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainContent_SudokuMode _003C_003E4__this;

		public int row;

		public int col;

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
		public _003CSelectSameCellAfterWrong_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CSetInitialGrid_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainContent_SudokuMode _003C_003E4__this;

		public float delay;

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
		public _003CSetInitialGrid_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CShowHandHelp_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainContent_SudokuMode _003C_003E4__this;

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
		public _003CShowHandHelp_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CShowIdleAnimation_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform obj;

		public MainContent_SudokuMode _003C_003E4__this;

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
		public _003CShowIdleAnimation_003Ed__37(int _003C_003E1__state)
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

	public static MainContent_SudokuMode Instance;

	[SerializeField]
	private GameObject _gridContainer;

	[SerializeField]
	private GameObject _redBG;

	[Header("Block")]
	[SerializeField]
	private GameObject _blockEmpty;

	[SerializeField]
	private GameObject _blockNumber;

	[SerializeField]
	private GameObject _blockQuestionRight;

	[SerializeField]
	private GameObject _blockQuestionBottom;

	[SerializeField]
	private Text _answerEditorText;

	[SerializeField]
	private ParticleSystem _screenChangeParticle;

	public AudioSource _audioSource;

	private int _gridRows;

	private int _gridColumns;

	private int[,] grid;

	private int[,] grid_temp;

	private int[] rowSums;

	private int[] colSums;

	private GameObject[,] blockReferences;

	private int? selectedRow;

	private int? selectedCol;

	[SerializeField]
	private Transform optionPanel;

	private int QuestionCompleteCount;

	private int totalQuestions;

	private int idleAnimIndex;

	private int correctAnswer;

	private GameObject _correctAnswerObj;

	private bool isFromFirstTime;

	private bool isHelpAvailable;

	private Coroutine _idleAnimationCoroutine;

	private Coroutine _handHelpCoroutine;

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

	[IteratorStateMachine(typeof(_003CSetInitialGrid_003Ed__33))]
	public IEnumerator SetInitialGrid(float delay)
	{
		return null;
	}

	private void GenerateAndSetGrid()
	{
	}

	private void AutoSelectCell()
	{
	}

	public void OnCellClicked(int row, int col, bool isChangeOptions = true)
	{
	}

	[IteratorStateMachine(typeof(_003CShowIdleAnimation_003Ed__37))]
	private IEnumerator ShowIdleAnimation(Transform obj)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowHandHelp_003Ed__38))]
	private IEnumerator ShowHandHelp()
	{
		return null;
	}

	private void StopHandHelp()
	{
	}

	private void ShowOptions()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableOptions_003Ed__41))]
	private IEnumerator EnableOptions(List<int> options)
	{
		return null;
	}

	public void PlaySound(string _number, bool IsBothAudioPlay = false)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__43))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f, SoundType _soundtype = SoundType.None)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayClipOnShot_003Ed__44))]
	public IEnumerator PlayClipOnShot(AudioClip audioClip, float Delay = 0f)
	{
		return null;
	}

	private void CheckAnswer(int value)
	{
	}

	[IteratorStateMachine(typeof(_003CSelectSameCellAfterWrong_003Ed__46))]
	private IEnumerator SelectSameCellAfterWrong(int row, int col)
	{
		return null;
	}

	public void EnableDisableMainPanel(bool isEnable, bool isDestroyed = false)
	{
	}
}
