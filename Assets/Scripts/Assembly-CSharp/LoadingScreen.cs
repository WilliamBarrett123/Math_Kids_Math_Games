using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.AssetDelivery;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
	private enum LoadingSceneState
	{
		LOADING_STARTUP = 0,
		LOADING_ASSETBUNDLES = 1,
		LOADING_DISCRETE = 2,
		LOADING_ASSETS = 3,
		LOADING_COMPLETE = 4,
		LOADING_ERROR = 5
	}

	[CompilerGenerated]
	private sealed class _003CBarFill_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScreen _003C_003E4__this;

		private int _003CRandomDisplay_003E5__2;

		private int[] _003ClstDisplayNumber_003E5__3;

		private float _003CClipLength_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CBarFill_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CCallDealy_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int startValue;

		public LoadingScreen _003C_003E4__this;

		public int stopValue;

		private int _003Cj_003E5__2;

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
		public _003CCallDealy_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CLoadAssetBundlesFromAssetPacks_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Queue<string> assetBundleQueue;

		public LoadingScreen _003C_003E4__this;

		private string _003CassetBundleName_003E5__2;

		private PlayAssetBundleRequest _003CbundleRequest_003E5__3;

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
		public _003CLoadAssetBundlesFromAssetPacks_003Ed__49(int _003C_003E1__state)
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
	private sealed class _003CLoadAssetBundlesFromStreaming_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Queue<string> assetBundleQueue;

		public LoadingScreen _003C_003E4__this;

		private int _003CcompleteCount_003E5__2;

		private string _003CassetBundlePath_003E5__3;

		private UnityWebRequest _003Crequest_003E5__4;

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
		public _003CLoadAssetBundlesFromStreaming_003Ed__51(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadAssetsFromQueue_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScreen _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CLoadAssetsFromQueue_003Ed__47(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScreen _003C_003E4__this;

		private int _003CrandomNumber_003E5__2;

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
		public _003CStart_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CStartVideoAnimations_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScreen _003C_003E4__this;

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
		public _003CStartVideoAnimations_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CStart_1_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CStart_1_003Ed__52(int _003C_003E1__state)
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
	private GameAssetManager gameAssetManager;

	private Queue<GameAssetReference> assetQueue;

	private List<Locale> locales;

	public LocaleData localeData;

	private LoadingSceneState loadingSceneState;

	private int totalItemsToLoad;

	private int currentItemsLoaded;

	[SerializeField]
	private string sceneToLoad;

	[SerializeField]
	private Text txtPercentage;

	[SerializeField]
	private Text txtLoadingScreen;

	[SerializeField]
	private Image PercentageFill;

	private bool isStartCalled;

	private bool isCallCompletedVideo;

	private bool DoEnableShadow;

	[SerializeField]
	private Transform PositionObject;

	[SerializeField]
	private Transform Lucas;

	[SerializeField]
	private Transform Ruby;

	[SerializeField]
	private Transform LogoImage;

	[SerializeField]
	private Transform SplashImage;

	[SerializeField]
	private Transform IntroContainer;

	[SerializeField]
	private Transform yt_btn;

	public static bool isSplashImageActive;

	private float delay;

	private float duration;

	private float from_scale;

	private float to_scale;

	private float LucasStartPositionX;

	private float LucasStartPositionY;

	private float LandingPositionY;

	private float LandingPositionX;

	private float CurrentAspect;

	private float default_Aspect;

	private int LaunchCount;

	[SerializeField]
	private Intro_Video_Friends objIntro_Video_Friends;

	private bool VideoPlaying;

	private void StartIntroVideoPlacement(bool isFromChange)
	{
	}

	[IteratorStateMachine(typeof(_003CStartVideoAnimations_003Ed__36))]
	private IEnumerator StartVideoAnimations()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 a)
	{
	}

	private static int getSDKInt()
	{
		return 0;
	}

	public void OnAnimationCompletes()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__43))]
	private IEnumerator Start()
	{
		return null;
	}

	private void SetLoadingSceneState(LoadingSceneState newState)
	{
	}

	public void LoadNextScene()
	{
	}

	private void StartLoadingAssets()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAssetsFromQueue_003Ed__47))]
	private IEnumerator LoadAssetsFromQueue()
	{
		return null;
	}

	private void StartLoadingAssetBundlesFromAssetPacks()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAssetBundlesFromAssetPacks_003Ed__49))]
	private IEnumerator LoadAssetBundlesFromAssetPacks(Queue<string> assetBundleQueue)
	{
		return null;
	}

	private void StartLoadingAssetBundlesFromStreaming()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAssetBundlesFromStreaming_003Ed__51))]
	private IEnumerator LoadAssetBundlesFromStreaming(Queue<string> assetBundleQueue)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStart_1_003Ed__52))]
	private IEnumerator Start_1()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBarFill_003Ed__53))]
	private IEnumerator BarFill()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCallDealy_003Ed__54))]
	private IEnumerator CallDealy(int startValue, int stopValue)
	{
		return null;
	}

	public bool IsInternetAvailable()
	{
		return false;
	}
}
