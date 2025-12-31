using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AddItUpFun : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveBalloonTop_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpFun _003C_003E4__this;

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
		public _003CMoveBalloonTop_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003COnAutoNextButton_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool SkipWait;

		public AddItUpFun _003C_003E4__this;

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
		public _003COnAutoNextButton_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003COnNextButtonClick_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpFun _003C_003E4__this;

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
		public _003COnNextButtonClick_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public AddItUpFun _003C_003E4__this;

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
		public _003CPlayClip_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CStartAnimation_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddItUpFun _003C_003E4__this;

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
		public _003CStartAnimation_003Ed__19(int _003C_003E1__state)
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

	public static AddItUpFun Instance;

	[SerializeField]
	private GameObject balloonParticles;

	[SerializeField]
	private GameObject balloonParticles_Char;

	[SerializeField]
	private GameObject balloonParticles_Char_End;

	[SerializeField]
	private GameObject handClickAnimation;

	[SerializeField]
	private GameObject BalloonPanel;

	[SerializeField]
	private GameObject CloneBalloon;

	private int helpShowCount;

	[SerializeField]
	private GameObject confetti;

	[SerializeField]
	private List<Sprite> lstBalloonImages;

	[SerializeField]
	private List<Sprite> lstCharacterImages;

	[SerializeField]
	private List<AudioClip> lstBalloonSpawn;

	private List<Vector3> lstBalloonPos;

	[SerializeField]
	private AnimationCurve moveCurve;

	private bool allballoonsPopped;

	private bool isLastBalloonPoped;

	[SerializeField]
	private AudioClip balloonpop;

	[SerializeField]
	private AudioClip balloonpopChar;

	[SerializeField]
	private AudioClip shoutAudio;

	[SerializeField]
	private AudioClip BalloonRealeaseSound;

	private bool fromAutoNext;

	private List<GameObject> lstReleaseSequence;

	private int BalloonCounter;

	private Color32 colorRed;

	private Color32 colorYellow;

	private Color32 colorGreen;

	private Color32 colorOrange;

	private Color32 colorBlue;

	private Color32 colorPink;

	private Color32 colorPurple;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimation_003Ed__19))]
	public IEnumerator StartAnimation(float delay = 0f)
	{
		return null;
	}

	public void OnCloseButtonPressed()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveBalloonTop_003Ed__21))]
	private IEnumerator MoveBalloonTop()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnAutoNextButton_003Ed__24))]
	public IEnumerator OnAutoNextButton(bool SkipWait = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnNextButtonClick_003Ed__25))]
	public IEnumerator OnNextButtonClick()
	{
		return null;
	}

	public void PopBalloon(GameObject thisGameObject)
	{
	}

	private void OnAnimationEventFire(string param)
	{
	}

	private void SetParticleReleaseEnd()
	{
	}

	public void SpawnBalloonParticle(Transform gameObjectTransform, GameObject _particle_1)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__44))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}
}
