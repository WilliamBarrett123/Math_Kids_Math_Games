using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class CollectGiftScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGiftOpenAfterFiveSeconds_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectGiftScreen _003C_003E4__this;

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
		public _003CGiftOpenAfterFiveSeconds_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003COpenGiftAfterDelay_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectGiftScreen _003C_003E4__this;

		public Transform GiftBox;

		public bool isAutoOpen;

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
		public _003COpenGiftAfterDelay_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CPlayClip_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public CollectGiftScreen _003C_003E4__this;

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
		public _003CPlayClip_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CSetIdleState_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectGiftScreen _003C_003E4__this;

		private List<string> _003ClstTempGiftBoxName_003E5__2;

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
		public _003CSetIdleState_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CShowHandHelpAnimation_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CShowHandHelpAnimation_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CStartLucasAnimation_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectGiftScreen _003C_003E4__this;

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
		public _003CStartLucasAnimation_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CToyParticle_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectGiftScreen _003C_003E4__this;

		public GameObject ToyObj;

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
		public _003CToyParticle_003Ed__40(int _003C_003E1__state)
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

	public static CollectGiftScreen Instance;

	[SerializeField]
	private SkeletonGraphic RabbitSpineSkeletonAnimation;

	[SerializeField]
	private GameObject ToyObj;

	[SerializeField]
	private GameObject AllBoxParent;

	[SerializeField]
	private GameObject titleHeader;

	[SerializeField]
	private GameObject hand_clickParent;

	[Header("GiftSound")]
	[SerializeField]
	private AudioClip Gift_Entry;

	[SerializeField]
	private AudioClip Gift_Shake;

	[SerializeField]
	private AudioClip Gift_Open;

	[SerializeField]
	private AudioClip Gift_Jump;

	[SerializeField]
	private AudioClip Gift_Tap;

	[SerializeField]
	private GameObject gift_star;

	private Vector3 Vector3One;

	private Vector3 Vector3Zero;

	private List<int> usedRandomToyList;

	private bool isGiftBoxClicked;

	private bool isTitleShown;

	private List<string> lstGiftBoxName;

	private bool isEntrySoundPlayed;

	private List<string> AlreadyCollected_Toys;

	private Transform clickedGiftBox;

	private int _randomVar;

	private int Counter;

	[SerializeField]
	private GameObject giftBalloons_particle;

	[SerializeField]
	private GameObject confetti_particle;

	[SerializeField]
	private GameObject backRays_Particle;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnAnimationEventFire(string param)
	{
	}

	private void onMusicChangeEvent()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLucasAnimation_003Ed__24))]
	public IEnumerator StartLucasAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetIdleState_003Ed__25))]
	private IEnumerator SetIdleState()
	{
		return null;
	}

	private void SetToy()
	{
	}

	private int getRandomNumber(List<int> ignoreArrayValue, int startFrom, int endTo)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CGiftOpenAfterFiveSeconds_003Ed__29))]
	private IEnumerator GiftOpenAfterFiveSeconds()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowHandHelpAnimation_003Ed__30))]
	private IEnumerator ShowHandHelpAnimation()
	{
		return null;
	}

	public void OnGiftBoxClick(Transform GiftBox)
	{
	}

	[IteratorStateMachine(typeof(_003COpenGiftAfterDelay_003Ed__35))]
	private IEnumerator OpenGiftAfterDelay(Transform GiftBox, bool isAutoOpen = false)
	{
		return null;
	}

	private void WriteToyData()
	{
	}

	[IteratorStateMachine(typeof(_003CToyParticle_003Ed__40))]
	private IEnumerator ToyParticle(GameObject ToyObj)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__41))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}
}
