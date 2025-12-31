using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LucasRoomRewamp : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public LucasRoomRewamp _003C_003E4__this;

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
		public _003CPlayClip_003Ed__25(int _003C_003E1__state)
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

	public static LucasRoomRewamp Instance;

	public GameObject Help;

	[SerializeField]
	private Transform screen_Main;

	[SerializeField]
	private Transform screen_Family;

	[SerializeField]
	private Transform screen_Friends;

	[SerializeField]
	private Transform MainContainer;

	private RectTransform MainContainer_rect;

	private float width;

	private float height;

	[SerializeField]
	private AudioSource src_audio;

	public GameObject[] AlertICons;

	public GameObject[] DowloadButtons;

	public AssetBundle modeBundle;

	public bool ISLucasGardenBundleRequestSend;

	[SerializeField]
	private ScrollRect _ScrollRect;

	public ParticleSystem _valentine_toran;

	public float Width;

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

	private void SetValues(float value)
	{
	}

	private void OnResolutionChangedEvent(Vector2 reoslution)
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__25))]
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

	public void OnValueChanged(Vector2 a)
	{
	}
}
