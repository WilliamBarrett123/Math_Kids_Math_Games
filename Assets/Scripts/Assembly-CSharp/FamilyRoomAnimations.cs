using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class FamilyRoomAnimations : CharacterManager
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public AudioClip audioClip;

		public bool IsplayOneShot;

		public FamilyRoomAnimations _003C_003E4__this;

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

	[CompilerGenerated]
	private sealed class _003CPlayFamilyAnimationsInSequence_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FamilyRoomAnimations _003C_003E4__this;

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
		public _003CPlayFamilyAnimationsInSequence_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CSetIDleAnimation_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FamilyRoomAnimations _003C_003E4__this;

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
		public _003CSetIDleAnimation_003Ed__65(int _003C_003E1__state)
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

	private SkeletonGraphic FatherSkeleton;

	private SkeletonGraphic MotherSkeleton;

	private SkeletonGraphic BabySkeleton;

	private bool ISFamilyIntroCoroutineRunning;

	private CharcterState FatherCharacterState;

	private CharcterState MotherCharacterState;

	private CharcterState BabyCharacterState;

	[SerializeField]
	private SkeletonGraphic Cat;

	[SerializeField]
	private AudioClip FamilyIntro;

	[SerializeField]
	private AudioClip FatherIntro;

	[SerializeField]
	private AudioClip MotherIntro;

	[SerializeField]
	private AudioClip BabyIntro;

	[SerializeField]
	[Header("Tap Sounds")]
	private AudioClip ClockSound;

	[Header("Tap Sounds")]
	[SerializeField]
	private AudioClip PlantSound;

	[Header("Tap Sounds")]
	[SerializeField]
	private AudioClip CurtainCloseSound;

	[Header("Tap Sounds")]
	[SerializeField]
	private AudioClip CurtainopenSound;

	[Header("Tap Sounds")]
	[SerializeField]
	private AudioClip LampSound;

	[SerializeField]
	[Header("Tap Sounds")]
	private AudioClip FamilyonVacationSound;

	[Header("Tap Sounds")]
	[SerializeField]
	private AudioClip ToyChairsound;

	[SerializeField]
	private Animator RightCurtainAnimator;

	[SerializeField]
	private Animator LeftCurtainAnimtaor;

	[SerializeField]
	private Animator LampAnimator;

	[SerializeField]
	private GameObject Window;

	[SerializeField]
	private GameObject TopBg;

	[SerializeField]
	private GameObject BottomBg;

	[SerializeField]
	private GameObject FamilyRoomBottompanel;

	[SerializeField]
	private AudioClip Cat_Laugh;

	[SerializeField]
	private AudioClip Cat_Meaw;

	[SerializeField]
	private AudioClip Cat_Meaw_Laugh_R;

	[SerializeField]
	private AudioClip Cat_N_Laugh;

	[SerializeField]
	private AudioClip Cat_N_Meaw_small;

	[SerializeField]
	private AudioClip Cat_N_Scared_jump;

	private bool ISFamilyRoomItemsClickble;

	[SerializeField]
	private AudioClip BG_N1_Rasberry_Laugh;

	[SerializeField]
	private AudioClip BG_N1_Rasberry_Laugh2;

	[SerializeField]
	private AudioClip BG_N1_Rasberry_Laugh3;

	private int HiLoopCounter;

	private int HiBlinkCounter;

	private int FatherIdleCounter;

	private int MotherIdleCounter;

	private int BabyIdleCounter;

	private int CatIdleCounter;

	private bool _Characterisclickable;

	private bool ISFamilyIDleCoroutineRunning;

	private int randint;

	private bool IsLampon;

	[SerializeField]
	private AudioClip giftboxes;

	private string _bagAnimName;

	[SerializeField]
	[Header("Easter Sounds")]
	[Space(20f)]
	private AudioClip hanging_Bell_Touch;

	private void OnEnable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 vector)
	{
	}

	private void OnDisable()
	{
	}

	private void CatEventCallBacks(TrackEntry trackEntry, Event e)
	{
	}

	private void BabyEventCallBacks(TrackEntry trackEntry, Event e)
	{
	}

	private void ClickOnFrindsButton(float obj)
	{
	}

	private void ClickOnFamilButton(float Delay)
	{
	}

	private void CloseButtonPressed()
	{
	}

	private void SetScalePosAccrodingToResolution()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayFamilyAnimationsInSequence_003Ed__45))]
	private IEnumerator PlayFamilyAnimationsInSequence(float Delay = 0f)
	{
		return null;
	}

	private void StopFamilySequnceCoroutine()
	{
	}

	private void CallDleAnimation()
	{
	}

	private void SetAllCharctersIdle()
	{
	}

	private void BabyCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	private void MotherCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	private void FatherCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	private void CatCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	private void SetIntro(SkeletonGraphic _SkeletonGraphic, string animName)
	{
	}

	public void OnChacterButtonClick(Transform character)
	{
	}

	private void ActivateButton()
	{
	}

	[IteratorStateMachine(typeof(_003CSetIDleAnimation_003Ed__65))]
	private IEnumerator SetIDleAnimation()
	{
		return null;
	}

	public void OnIdleChacterButtonClick(SkeletonGraphic character)
	{
	}

	public void OnCatButtonClick()
	{
	}

	public void OnPalntButtonClick(Transform thisTransForm)
	{
	}

	public void OnClockButtonClick(Transform thisTransForm)
	{
	}

	public void OnSofaButtonClick(Transform thisTransForm)
	{
	}

	public void OnPotButtonClick(Transform thisTransForm)
	{
	}

	public void OnClickonPhotoFrame(Transform thisTransForm)
	{
	}

	public void OnLampAndWidowButtonClick(Transform thisTransForm)
	{
	}

	private void SetLampAndWindow()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__76))]
	public IEnumerator PlayClip(AudioClip audioClip, float Delay = 0f, bool IsplayOneShot = false)
	{
		return null;
	}

	public void OnGiftButtonClick(Transform btnTransform)
	{
	}

	public void OnSurpriseBagClicked(Transform thisTransForm)
	{
	}

	public void OnPotClick_EasterTheme(Transform thisTransForm)
	{
	}

	public void OnThemeObjectClick(Transform thisTransForm)
	{
	}
}
