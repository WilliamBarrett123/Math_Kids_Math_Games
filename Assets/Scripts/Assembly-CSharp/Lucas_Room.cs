using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Lucas_Room : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public Lucas_Room _003C_003E4__this;

		public AudioClip CurrentClip;

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
		public _003CPlayClip_003Ed__50(int _003C_003E1__state)
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

	public static Lucas_Room Instance;

	public GameObject Help;

	[SerializeField]
	private Transform screen_Main;

	[SerializeField]
	private Transform screen_Family;

	[SerializeField]
	private Transform screen_Friends;

	[SerializeField]
	private Transform MainContainer;

	[SerializeField]
	private Transform screen_Demo;

	[SerializeField]
	private Transform BGContainer;

	[SerializeField]
	private Family_Character_Anim _family_anim_script;

	[SerializeField]
	private Friends_Character_Anim _friends_anim_script;

	public LucasRoom_DemoScreen _DemoScreen_script;

	private RectTransform MainContainer_rect;

	private float width;

	private float height;

	private int currentscreen;

	private string screentocall;

	[SerializeField]
	private AudioSource src_audio;

	[SerializeField]
	private AudioClip _familyIntro;

	[SerializeField]
	private AudioClip _friendIntro;

	[SerializeField]
	private AudioClip _bugleBlow;

	[SerializeField]
	private AudioClip _danceRoom;

	public _LucasState _StateForDemoScreen;

	public GameObject CloseCC;

	public Selectable btnClose;

	public Selectable btn_family;

	[SerializeField]
	private GameObject AlertICon;

	[SerializeField]
	private GameObject DowloadButton;

	public AssetBundle modeBundle;

	public bool ISLucasGardenBundleRequestSend;

	private float PosX;

	[SerializeField]
	private GameObject Whitetransition;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnInitLucasRoom(_LucasState _state)
	{
	}

	private void OnEnable()
	{
	}

	public void OnResetLucasRoom()
	{
	}

	private void SetCloseButtonNavigation(bool isToMain = false)
	{
	}

	public void TransitScreenToScreen2()
	{
	}

	public void TransitToMainScreenFromFamilyScreen()
	{
	}

	public void TransitToMainScreenFromFriendsScreen()
	{
	}

	public void TransitToMainScreenFromDemoScreen()
	{
	}

	private void SetValues(float value)
	{
	}

	public void OnClickOfDanceButton(Transform thisTransform)
	{
	}

	public void OnClickOfBugleButton(Transform thisTransform)
	{
	}

	public void OnClickOfFamilyButton(Transform thisTransform)
	{
	}

	public void CallFamilyScreen()
	{
	}

	public void OnClickOfFriendsButton(Transform thisTransform)
	{
	}

	public void CallFriendsScreen()
	{
	}

	public void CallDemoScreenScreen(_LucasState _state)
	{
	}

	private void OnResolutionChangedEvent(Vector2 reoslution)
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__50))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}

	public void OnCloseClick()
	{
	}

	public void OnClickToyGarden(Transform thisTransform)
	{
	}

	private void DowloadComplete(bool isSucess)
	{
	}

	private void SpawnnewCCScreen()
	{
	}
}
