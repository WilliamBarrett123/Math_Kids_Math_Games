using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HideMainScreenButtons : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayLucasRoomLightAnimation_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HideMainScreenButtons _003C_003E4__this;

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
		public _003CPlayLucasRoomLightAnimation_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CSetToggleValue_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HideMainScreenButtons _003C_003E4__this;

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
		public _003CSetToggleValue_003Ed__17(int _003C_003E1__state)
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

	[SerializeField]
	private GameObject IsMoreBtn;

	[SerializeField]
	private GameObject IsOurStorybtn;

	[SerializeField]
	private GameObject IsLucasRoombtn;

	[SerializeField]
	private GameObject IsOurStoryContainer;

	[SerializeField]
	private GameObject iSlucasRoomICon;

	[SerializeField]
	private Text Text1;

	[SerializeField]
	private GameObject DownloadIconLucasRoom;

	[SerializeField]
	private GameObject AlertIConLucasRoom;

	[SerializeField]
	private GameObject ProgressIconLucasRoom;

	[SerializeField]
	private GameObject _newShopAmazonIcon;

	[SerializeField]
	private GameObject _oldShopNonAmazonIcon;

	[SerializeField]
	private GameObject _shopIconIos;

	private bool playAudio;

	[SerializeField]
	private GameObject _light2;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLoadUser()
	{
	}

	[IteratorStateMachine(typeof(_003CSetToggleValue_003Ed__17))]
	private IEnumerator SetToggleValue()
	{
		return null;
	}

	public void IsMoreApp(Toggle btn)
	{
	}

	public void IsOurStory(Toggle btn)
	{
	}

	private void SettingTextID()
	{
	}

	public void IsLucasRoomBtn(Toggle btn)
	{
	}

	public void onCloseButtonClick(GameObject currentButton)
	{
	}

	private void onClosePress()
	{
	}

	private void SetShopIcon()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayLucasRoomLightAnimation_003Ed__26))]
	public IEnumerator PlayLucasRoomLightAnimation()
	{
		return null;
	}
}
