using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class OurStory_Video : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayVideoAfterClicked_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool IsCallFrameDelay;

		public OurStory_Video _003C_003E4__this;

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
		public _003CPlayVideoAfterClicked_003Ed__29(int _003C_003E1__state)
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

	public static OurStory_Video Instance;

	[SerializeField]
	private VideoPlayer thisVideoplayer;

	[SerializeField]
	private GameObject btn_Play;

	[SerializeField]
	private GameObject btn_Pause;

	[SerializeField]
	private GameObject btn_Download;

	[SerializeField]
	private GameObject btn_Replay;

	[SerializeField]
	private GameObject btn_Motivations;

	[SerializeField]
	private GameObject btn_share;

	public GameObject btn_AllScreen;

	[SerializeField]
	private Image FillBar;

	[HideInInspector]
	public bool isFromHelp;

	[HideInInspector]
	public bool isFromOurStory;

	private double videoProgressTime;

	private bool issetvalue;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void selectSelectableAfterDelay()
	{
	}

	private void OnVideoDownloadCompletedEvent(bool isresult)
	{
	}

	private void OnVideoDownloadProcessEvent(float process)
	{
	}

	private void OnVideoPlayFinished(VideoPlayer player)
	{
	}

	private void OnVideoPrepareCompleted(VideoPlayer player)
	{
	}

	public void onCloseButtonPressed(GameObject thisGameObject)
	{
	}

	private void DisplayMessage()
	{
	}

	public void onReplayButtonPressed(GameObject thisGameObject)
	{
	}

	public void onPlayButtonPressed(GameObject thisGameObject)
	{
	}

	public void onPauseButtonPressed(GameObject thisGameObject)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayVideoAfterClicked_003Ed__29))]
	private IEnumerator PlayVideoAfterClicked(bool IsCallFrameDelay = false)
	{
		return null;
	}

	public void onClickAnyPlace(GameObject thisGameObject)
	{
	}

	private void DisablePauseButton()
	{
	}

	public void onShareButtonClicked(GameObject thisGameObject)
	{
	}

	private void share()
	{
	}

	private void onNativeButtonPress()
	{
	}

	private void setKeybaordHighlight()
	{
	}
}
