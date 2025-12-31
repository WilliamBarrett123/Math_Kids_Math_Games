using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;
using UnityEngine.UI;

public class ManageLucasParent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBalloonAnim_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CBalloonAnim_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CLucasLeftRightMove_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

		private float _003Cval_003E5__2;

		private float _003C_timer_003E5__3;

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
		public _003CLucasLeftRightMove_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CPlayClip_003Ed__61(int _003C_003E1__state)
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
	private sealed class _003CStartBalloonReleaseAnimation_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CStartBalloonReleaseAnimation_003Ed__48(int _003C_003E1__state)
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
	private sealed class _003CStartBrushAnimation_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CStartBrushAnimation_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CStartJumpAnimation_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CStartJumpAnimation_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CStartJumpAnimationAfterDelay_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CStartJumpAnimationAfterDelay_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CStartPickabooAnimation_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CStartPickabooAnimation_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CwarmUpLucasOutSideScreen_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManageLucasParent _003C_003E4__this;

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
		public _003CwarmUpLucasOutSideScreen_003Ed__63(int _003C_003E1__state)
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

	public static ManageLucasParent Instance;

	public _LucasState _currentLucasState;

	[SerializeField]
	private AudioClip jump;

	[SerializeField]
	private AudioClip letsjump;

	[SerializeField]
	private AudioClip brush;

	[SerializeField]
	private AudioClip teethdisplay;

	[SerializeField]
	private AudioClip pickaboo;

	[SerializeField]
	private AudioClip balloonPop;

	[SerializeField]
	private AudioClip peekaboo_In;

	[SerializeField]
	private AudioClip peekaboo_Out;

	[SerializeField]
	private AudioClip Big_Ball_1;

	[SerializeField]
	private AudioClip Big_Ball_2;

	[SerializeField]
	private AudioClip Touch_Hi_iam_Lucas;

	[SerializeField]
	private AudioClip Touch_Hi;

	[SerializeField]
	private AudioClip jump_intro;

	[SerializeField]
	private AudioClip Tummy1;

	[SerializeField]
	private Text _width;

	[SerializeField]
	private AudioClip letshavesomeFun;

	[SerializeField]
	private AudioClip realaseBallon;

	[SerializeField]
	private AudioClip laughLucas;

	[SerializeField]
	private AudioClip BalloonRealeaseSound;

	[SerializeField]
	private AudioClip releaseBalloonlaugh;

	[SerializeField]
	private AudioClip jumpLocalize;

	[SerializeField]
	private GameObject Balloon;

	[SerializeField]
	private GameObject BalloonwithHand;

	public GameObject BalloonPop;

	private GameObject refBalloon;

	[SerializeField]
	private Transform CanvasRef;

	private Vector3[] _Balloonpath;

	private Vector3[] _BalloonpthR;

	private Vector3[] _BalloonpathOriginal;

	private Vector3[] _BalloonpathROriginal;

	public AudioSource src_audio;

	private int jumpSoundCounter;

	private int BallonPath;

	private int jumpCounter;

	public int LucasIdleAnimCounter;

	private List<Vector3> StartPos_Lucas_Pickaboo;

	private List<Vector3> endPos_Lucas_Pickaboo;

	private Vector3 peekbooStartPos;

	private int randomNumber;

	private bool lucaswarmingup;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void _lucasCharacter_Anim_Event_callbacks(TrackEntry trackEntry, Event e)
	{
	}

	[IteratorStateMachine(typeof(_003CBalloonAnim_003Ed__39))]
	private IEnumerator BalloonAnim()
	{
		return null;
	}

	private void WaypointChanged(int waypointIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CLucasLeftRightMove_003Ed__42))]
	private IEnumerator LucasLeftRightMove()
	{
		return null;
	}

	private void _lucasCharacter_Anim_Start_callbacks(TrackEntry trackEntry)
	{
	}

	private void _lucasCharacter_Anim_Complete_callbacks(TrackEntry trackEntry)
	{
	}

	[IteratorStateMachine(typeof(_003CStartJumpAnimationAfterDelay_003Ed__46))]
	private IEnumerator StartJumpAnimationAfterDelay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartJumpAnimation_003Ed__47))]
	public IEnumerator StartJumpAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartBalloonReleaseAnimation_003Ed__48))]
	public IEnumerator StartBalloonReleaseAnimation()
	{
		return null;
	}

	public void EndBalloonReleaseAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CStartPickabooAnimation_003Ed__52))]
	public IEnumerator StartPickabooAnimation()
	{
		return null;
	}

	public void CallPickabooAnim()
	{
	}

	public void EndPickabooAnimAndStartNew()
	{
	}

	private void lucasPeekEnd()
	{
	}

	public void EndJumpAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CStartBrushAnimation_003Ed__59))]
	public IEnumerator StartBrushAnimation()
	{
		return null;
	}

	public void EndBrushAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__61))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CwarmUpLucasOutSideScreen_003Ed__63))]
	public IEnumerator warmUpLucasOutSideScreen()
	{
		return null;
	}
}
