using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.Common;
using Google.Play.Review;
using UnityEngine;

public class NativeReview_Manager : Singleton<NativeReview_Manager>
{
	[CompilerGenerated]
	private sealed class _003CLaunchFlowCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NativeReview_Manager _003C_003E4__this;

		private PlayAsyncOperation<VoidResult, ReviewErrorCode> _003ClaunchFlowOperation_003E5__2;

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
		public _003CLaunchFlowCoroutine_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CRequestFlowCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NativeReview_Manager _003C_003E4__this;

		private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> _003CrequestFlowOperation_003E5__2;

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
		public _003CRequestFlowCoroutine_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CShowNativeReview_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public NativeReview_Manager _003C_003E4__this;

		public bool isFromButtonClick;

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
		public _003CShowNativeReview_003Ed__16(int _003C_003E1__state)
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

	private static PlayReviewInfo _playReviewInfo;

	private ReviewManager _reviewManager;

	public bool isRequestSuccess;

	[HideInInspector]
	public bool IsReviewDisplayedInCurrentLaunch;

	[HideInInspector]
	public int NewReviewFlowIntegratedVersionCode;

	[HideInInspector]
	public int AutoLaunchStarRatingLaunchCountIncrement_Print;

	[HideInInspector]
	public int AutoLaunchStarRatingLaunchCountIncrement_OldUser;

	[HideInInspector]
	public int LaunchCountDifferenceForDisplayNativeReview;

	public static bool IsReviewFlowCompleted => false;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void requestreview()
	{
	}

	public void InitializeReviewDemo()
	{
	}

	public bool DisplayReviewConditions(float delay = 0f, bool isFromButtonClick = false, bool isFromAboutUs = false)
	{
		return false;
	}

	public void RequestReviewFlow()
	{
	}

	[IteratorStateMachine(typeof(_003CShowNativeReview_003Ed__16))]
	private IEnumerator ShowNativeReview(float delay = 0f, bool isFromButtonClick = false)
	{
		return null;
	}

	public void LaunchReviewFlow()
	{
	}

	[IteratorStateMachine(typeof(_003CRequestFlowCoroutine_003Ed__18))]
	private IEnumerator RequestFlowCoroutine(bool isStepRequest)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLaunchFlowCoroutine_003Ed__19))]
	private IEnumerator LaunchFlowCoroutine()
	{
		return null;
	}

	public void CheckForShareorther()
	{
	}

	public bool IsSupportNativeReview()
	{
		return false;
	}
}
