using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LucasRoomAnimations : CharacterManager
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public AudioClip audioClip;

		public bool IsplayOneShot;

		public LucasRoomAnimations _003C_003E4__this;

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
		public _003CPlayClip_003Ed__88(int _003C_003E1__state)
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
	private sealed class _003CSetLeftReverseAnimation_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LucasRoomAnimations _003C_003E4__this;

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
		public _003CSetLeftReverseAnimation_003Ed__62(int _003C_003E1__state)
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

	public static LucasRoomAnimations Instance;

	[SerializeField]
	private float LucasMovingoffsetFrinds;

	[SerializeField]
	private float LucasMovingoffsetFamily;

	[SerializeField]
	private GameObject Content;

	[SerializeField]
	private RectTransform CenterOfFamily;

	[SerializeField]
	private RectTransform CenterOfFriends;

	public static Action<float> ClickOnFamilyButtonEvent;

	public static Action<float> ClickOnFriendsButtonEvent;

	public static Action CloseButtonPressedEvent;

	private bool ismovingLeft;

	public static PresentRoom LucasState;

	[SerializeField]
	private GameObject LeftSidePhotoFrames;

	[SerializeField]
	private GameObject Lamp;

	[SerializeField]
	private GameObject BookShelf;

	[SerializeField]
	private AudioClip Blowing_Whistle;

	[SerializeField]
	private Transform DuckImage;

	[SerializeField]
	private Button BackButton;

	[SerializeField]
	private Button LucasButton;

	[SerializeField]
	private RectTransform Frame1;

	[SerializeField]
	private RectTransform Frame3;

	[SerializeField]
	private AudioClip DuckSound;

	[SerializeField]
	private AudioClip PenStandSound;

	[SerializeField]
	private AudioClip LampTapSound;

	[SerializeField]
	private AudioClip DrawerOpenSound;

	[SerializeField]
	private AudioClip DrawerCloseSound;

	[SerializeField]
	private AudioClip TeddySound;

	[SerializeField]
	private AudioClip DanceSound;

	[SerializeField]
	private AudioClip BookSound;

	[SerializeField]
	private AudioClip AppearSound;

	[SerializeField]
	private AudioClip juggleSound;

	[SerializeField]
	private AudioClip HappyWalk;

	[SerializeField]
	private AudioClip[] PotSounds;

	[SerializeField]
	private GameObject LampLucasRoom;

	[SerializeField]
	private GameObject LeftSidePhotoPanel;

	[SerializeField]
	private GameObject LucasRoomBottompanel;

	[SerializeField]
	private RectTransform Brody;

	[SerializeField]
	private ExplicitKeyboardNavigation _explicitKeyboardScript;

	private bool LucasRoomItemsClickble;

	private int potSoundCounter;

	private bool ContentPositionAfterFamilyButtonClicked;

	private bool ContentPositionAfterFriendsButtonClicked;

	[SerializeField]
	private Animator MonkeyAnimator;

	[SerializeField]
	private AudioClip MonkeyjumpSound;

	[SerializeField]
	private AudioClip Lu_N_ROLF;

	[SerializeField]
	private AudioClip Tummy_Hand_1;

	[SerializeField]
	private AudioClip Point_Laugh;

	[SerializeField]
	private AudioClip Point_Laugh_Flip;

	private GameObject ReSpawnObject;

	private bool IsSpawningDone;

	private int NewAnimNumber;

	public static bool _lionInTransitionstate;

	[SerializeField]
	[Header("Easter Sounds")]
	[Space(20f)]
	private AudioClip Desi_Egg_Jump_happy_Roation;

	[Space(20f)]
	[Header("Easter Sounds")]
	[SerializeField]
	private AudioClip Egg_Rabbit_Top_open;

	private bool isLidOpen;

	[SerializeField]
	private AudioClip hanging_Bell;

	[SerializeField]
	private AudioClip christmasTree;

	[SerializeField]
	private GameObject _lampLight;

	[SerializeField]
	private ParticleSystem _christmasParticle;

	[SerializeField]
	private ParticleSystem _valentine_Heart;

	[SerializeField]
	private ParticleSystem _valentine_flower;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 vector)
	{
	}

	private void SetScalePosAccrodingToResolution()
	{
	}

	private void UpdateLayout()
	{
	}

	public void OnMusicInstruMentCalled(Transform thisTransform)
	{
	}

	private void SetActiveGameObejct()
	{
	}

	public void OnClickOfFamilyButton(Transform thisTransform)
	{
	}

	public void OnClickOfFriendsButton(Transform thisTransform)
	{
	}

	private void Setnavigation()
	{
	}

	private void SetLucasScale(float travelTime)
	{
	}

	private void SetBrodyStatus()
	{
	}

	[IteratorStateMachine(typeof(_003CSetLeftReverseAnimation_003Ed__62))]
	private IEnumerator SetLeftReverseAnimation()
	{
		return null;
	}

	public void OnClickOfDanceButton(Transform thisTransform)
	{
	}

	public void _OnPointerDown(BaseEventData data)
	{
	}

	public void OnClickOfNewAnimationButton()
	{
	}

	public void OnBallsButtonClick(Transform thisTransform)
	{
	}

	public void OnCloseButtonPressed(Transform thisTransform)
	{
	}

	private void SetLionBackTOLucasRoom()
	{
	}

	public void ClickonDrawerButton(Transform thisTransform)
	{
	}

	public void OnTeddyButonClick(Transform thisTransForm)
	{
	}

	public void OnDuckButtonClick(Transform thisTransForm)
	{
	}

	public void OnPenStandButonClick(Transform thisTransForm)
	{
	}

	public void OnLampButonClick(Transform thisTransForm)
	{
	}

	public void OnpotButtonClick(Transform thisTransForm)
	{
	}

	public void OnValentinePotButtonClick(Transform thisTransForm)
	{
	}

	public void OnpotButtonClick_EasterTheme(Transform thisTransForm)
	{
	}

	public void OnThemeObjectClick(Transform thisTransForm)
	{
	}

	public void OnPumpkinButtonClick(Transform thisTransForm)
	{
	}

	public void OnBookButonClick(Transform thisTransForm)
	{
	}

	private void SwitchPosition()
	{
	}

	private void SetAnchorAndPivot(RectTransform ObjectRectTransform, Vector2 Pivot, Vector2 Position)
	{
	}

	private void MirrorPosition(RectTransform Object1, RectTransform Object2)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__88))]
	public IEnumerator PlayClip(AudioClip audioClip, float Delay = 0f, bool IsplayOneShot = false)
	{
		return null;
	}

	public void OnHangingStarsClick(Transform btnTransform)
	{
	}

	public void OnChristmasTreeClick(Transform btnTransform)
	{
	}
}
