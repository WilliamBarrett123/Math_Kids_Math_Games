using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class FreindsRoomAnimations : CharacterManager
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public AudioClip audioClip;

		public bool IsplayOneShot;

		public FreindsRoomAnimations _003C_003E4__this;

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
		public _003CPlayClip_003Ed__103(int _003C_003E1__state)
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
	private sealed class _003CPlayFriendsAnimationsInSequence_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FreindsRoomAnimations _003C_003E4__this;

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
		public _003CPlayFriendsAnimationsInSequence_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CSetIDleAnimation_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FreindsRoomAnimations _003C_003E4__this;

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
		public _003CSetIDleAnimation_003Ed__80(int _003C_003E1__state)
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

	private SkeletonGraphic RubySkeleton;

	private SkeletonGraphic LillySkeleton;

	private SkeletonGraphic BrodySkeleton;

	private bool ISFriendIntroCoroutineRunning;

	private CharcterState RubyCharacterState;

	private CharcterState LillyCharacterState;

	private CharcterState BrodyCharacterState;

	[SerializeField]
	private AudioClip FriendsRoomIntro1;

	[SerializeField]
	private AudioClip FriendsRoomIntro2;

	[SerializeField]
	private AudioClip TheyareMyBestFriends;

	[SerializeField]
	private AudioClip RubyIntro;

	[SerializeField]
	private AudioClip LillyIntro;

	[SerializeField]
	private AudioClip BrodyIntro1;

	[SerializeField]
	private AudioClip BrodyIntro2;

	[SerializeField]
	private AudioClip FriendsBeachSound;

	[SerializeField]
	private AudioClip FishjumpSound;

	[SerializeField]
	private AudioClip HeyLetsDance;

	[SerializeField]
	private AudioClip LetsDanceTogether;

	[SerializeField]
	private AudioClip DanceLoopSound;

	[SerializeField]
	private AudioClip LetshaveSomeFun;

	[SerializeField]
	private AudioClip MyNameisLucas;

	[SerializeField]
	private AudioClip RubytheRabbit;

	[SerializeField]
	private AudioClip LillytheCat;

	[SerializeField]
	private AudioClip BrodytheBear;

	[SerializeField]
	private AudioClip CupBoardCar;

	[SerializeField]
	private AudioClip CupBOardCommonSound;

	[SerializeField]
	private AudioClip BirdSound;

	[SerializeField]
	private AudioClip SmallCarSound;

	[SerializeField]
	private AudioClip BigCarSound;

	[SerializeField]
	private AudioClip TrainSound;

	[SerializeField]
	private AudioClip[] TeddySouds;

	[SerializeField]
	private AudioClip[] ElephentSounds;

	[SerializeField]
	private GameObject ToyChair;

	[SerializeField]
	private GameObject FrinedsRoomBottompanel;

	public static bool BrodyIsOutSideScreen;

	public static float BrodymovingPosition;

	private bool ISFriendsRoomItemsClickble;

	[SerializeField]
	private AudioClip B1_Tease;

	[SerializeField]
	private AudioClip B1_Tease_01;

	[SerializeField]
	private AudioClip Li_Tease01;

	[SerializeField]
	private AudioClip RD_N_Tease01;

	[SerializeField]
	private AudioClip RD_N_Expression_02;

	[SerializeField]
	private AudioClip Brody_Yehhh;

	[SerializeField]
	private AudioClip Brody_Hello;

	[SerializeField]
	private AudioClip Brody_Blink;

	[SerializeField]
	private AudioClip Brody_Whoohhh;

	[SerializeField]
	private AudioClip Brody_Laugh;

	[SerializeField]
	private AudioClip Brody_Laugh_1;

	[SerializeField]
	private AudioClip Brody_Laugh_2;

	[SerializeField]
	private AudioClip Hey;

	[SerializeField]
	private AudioClip Lilly_Yeahhh;

	[SerializeField]
	private AudioClip Hi_Lilly;

	[SerializeField]
	private AudioClip Lilly_laugh;

	[SerializeField]
	private AudioClip Lilly_Blink;

	[SerializeField]
	private AudioClip Lilly_Ohh;

	[SerializeField]
	private AudioClip Lilly_laugh1;

	[SerializeField]
	private AudioClip Ruby_Yaaaa;

	[SerializeField]
	private AudioClip Ruby_Blink;

	[SerializeField]
	private AudioClip Ruby_hi;

	[SerializeField]
	private AudioClip Ruby_Laugh;

	[SerializeField]
	private AudioClip Ruby_Ummmmm;

	[SerializeField]
	private AudioClip Ruby_Ohh_1;

	[SerializeField]
	private AudioClip Ruby_Laugh_1;

	private bool IsIDleCoroutineIsWaiting;

	public static bool FriendsIDleCoroutineRunning;

	private int AnimationNumber;

	private int LillyIdleCounter;

	private int RubyIdleCounter;

	private int BrodyIdleCounter;

	private int BrodyLookCounter;

	private int LiilyLookCounter;

	private int RubyLookCounter;

	private bool _Characterisclickable;

	[SerializeField]
	private AudioClip balls_Touch;

	[SerializeField]
	private AudioClip snowGlobe;

	[SerializeField]
	private ParticleSystem _snowParticle;

	private readonly string _shoesScaleAnimName;

	[Space(20f)]
	[Header("Easter Sounds")]
	[SerializeField]
	private AudioClip Pot_Rabbit_Tap;

	private void OnEnable()
	{
	}

	private void BrodyEventCallBacks(TrackEntry trackEntry, Event e)
	{
	}

	private void LillyEventCallBacks(TrackEntry trackEntry, Event e)
	{
	}

	private void RubyEventCallBacks(TrackEntry trackEntry, Event e)
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 vector)
	{
	}

	public void SetScalePosAccrodingToResolution()
	{
	}

	private void CloseButtonPressed()
	{
	}

	private void ClickOnFrindsButton(float Delay)
	{
	}

	private void ClickOnFamilyButton(float obj)
	{
	}

	private void StopIdleAndFrindsCorutine()
	{
	}

	private void CallDleAnimation()
	{
	}

	private void SetAllCharctersIdle()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayFriendsAnimationsInSequence_003Ed__76))]
	private IEnumerator PlayFriendsAnimationsInSequence(float Delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetIDleAnimation_003Ed__80))]
	private IEnumerator SetIDleAnimation()
	{
		return null;
	}

	private void BrodyCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	private void LillyCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	private void RubyCompleteCallBacks(TrackEntry trackEntry)
	{
	}

	public void OnChacterButtonClick(Transform character)
	{
	}

	private void ActivateButton()
	{
	}

	public void OnToyChairButonClick(Transform thisTransForm)
	{
	}

	public void OnTeddyElePhentButonClick(Transform thisTransForm)
	{
	}

	public void OnSmallCarButtonClick(Transform thisTransForm)
	{
	}

	public void OnBigCarButtonClick(Transform thisTransForm)
	{
	}

	public void OnBirdButtonClick(Transform thisTransForm)
	{
	}

	public void OnCupBOardCarButtonClick(Transform thisTransForm)
	{
	}

	public void OnCupBOardCommonButtonClick(Transform thisTransForm)
	{
	}

	public void OnAuqariumButtonClick(Transform thisTransForm)
	{
	}

	public void OnClickonPhotoFrame(Transform thisTransForm)
	{
	}

	public void OnTrainButtonClick(Transform thisTransForm)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__103))]
	public IEnumerator PlayClip(AudioClip audioClip, float Delay = 0f, bool IsplayOneShot = false)
	{
		return null;
	}

	public void OnHangingBallsClick(Transform btnTransform)
	{
	}

	public void OnSnowGlobeClick(Transform btnTransform)
	{
	}

	public void OnShoesButtonClick(GameObject thisgameobject)
	{
	}

	public void OnThemeObjectClick(Transform thisTransForm)
	{
	}
}
