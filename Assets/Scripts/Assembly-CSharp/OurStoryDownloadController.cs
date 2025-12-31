using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.AssetDelivery;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Video;

public class OurStoryDownloadController : Singleton<OurStoryDownloadController>
{
	[CompilerGenerated]
	private sealed class _003CAsyncDownloadVideoFromAssetDelivery_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OurStoryDownloadController _003C_003E4__this;

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
		public _003CAsyncDownloadVideoFromAssetDelivery_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CAsyncDownloadVideoFromServer_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OurStoryDownloadController _003C_003E4__this;

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
		public _003CAsyncDownloadVideoFromServer_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CShowProgress_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayAssetBundleRequest bundleRequest;

		private WaitForSeconds _003Cwaitfordelay_003E5__2;

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
		public _003CShowProgress_003Ed__15(int _003C_003E1__state)
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

	private bool IsCalledFromDownload;

	private UnityWebRequest wwwdownload;

	[HideInInspector]
	public string videopath;

	[HideInInspector]
	public VideoClip rveducation;

	[HideInInspector]
	public bool isVideoCurrentDownload;

	private string assetNamerveducation;

	private string youTubeURL;

	public static event Action<bool> OnVideoDownloadCompleted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<float> OnVideoDownloadProcess
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public void DownloadVideoFromServer()
	{
	}

	[IteratorStateMachine(typeof(_003CAsyncDownloadVideoFromAssetDelivery_003Ed__14))]
	private IEnumerator AsyncDownloadVideoFromAssetDelivery()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowProgress_003Ed__15))]
	private IEnumerator ShowProgress(PlayAssetBundleRequest bundleRequest)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAsyncDownloadVideoFromServer_003Ed__16))]
	private IEnumerator AsyncDownloadVideoFromServer()
	{
		return null;
	}

	private void DisplayDownloadProcess()
	{
	}

	public bool isVideoDownloadAtPath()
	{
		return false;
	}

	public bool isVideoDownloadAtPathForShare()
	{
		return false;
	}

	public void getYoutubeLink()
	{
	}

	private void openLink()
	{
	}
}
