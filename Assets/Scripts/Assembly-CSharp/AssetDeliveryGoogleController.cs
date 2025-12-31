using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.AssetDelivery;
using Google.Play.Common;
using UnityEngine;

public class AssetDeliveryGoogleController : Singleton<AssetDeliveryGoogleController>
{
	private enum AssetPackInfoStatus
	{
		PACKSTATUS_PENDING = 0,
		PACKSTATUS_NEEDS_DOWNLOAD = 1,
		PACKSTATUS_NEEDS_PERMISSION = 2,
		PACKSTATUS_DOWNLOADING = 3,
		PACKSTATUS_READY = 4,
		PACKSTATUS_ERROR = 5
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public bool isSuccessfullyDownload;

		public AssetDeliveryGoogleController _003C_003E4__this;

		internal void _003CLoadLucasGardenBundle_003Eb__0(PlayAssetBundleRequest bundleRequest, bool status)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public bool isSuccessfullyDownload;

		public AssetDeliveryGoogleController _003C_003E4__this;

		internal void _003CLoadLucasRoomRevampBundle_003Eb__0(PlayAssetBundleRequest bundleRequest, bool status)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public AssetDeliveryGoogleController _003C_003E4__this;

		public string assetName;

		internal bool _003CDownloadOrLoadSoundBundle_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public PlayAssetBundleRequest bundleRequest;

		public Func<bool> _003C_003E9__0;

		internal bool _003CLoadAssetBundleCoroutine_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownloadOrLoadSoundBundle_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

		public string assetName;

		private _003C_003Ec__DisplayClass69_0 _003C_003E8__1;

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
		public _003CDownloadOrLoadSoundBundle_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CDownloadSoundsBundles_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CDownloadSoundsBundles_003Ed__71(int _003C_003E1__state)
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
	private sealed class _003CLoadAddSubUFOModeBundle_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadAddSubUFOModeBundle_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CLoadAssetBundleCoroutine_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayAssetBundleRequest bundleRequest;

		public string assetBundleName;

		private _003C_003Ec__DisplayClass79_0 _003C_003E8__1;

		public AssetDeliveryGoogleController _003C_003E4__this;

		public Action<PlayAssetBundleRequest, bool> callback;

		private PlayAsyncOperation<ConfirmationDialogResult, AssetDeliveryErrorCode> _003CuserConfirmationOperation_003E5__2;

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
		public _003CLoadAssetBundleCoroutine_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CLoadBannerBundle_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadBannerBundle_003Ed__95(int _003C_003E1__state)
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
	private sealed class _003CLoadCarModeBundle_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadCarModeBundle_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CLoadEnglishSound_En_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadEnglishSound_En_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CLoadFunSnowModeBundle_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadFunSnowModeBundle_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CLoadLucasGardenBundle_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

		private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

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
		public _003CLoadLucasGardenBundle_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CLoadLucasRoomRevampBundle_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

		private _003C_003Ec__DisplayClass54_0 _003C_003E8__1;

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
		public _003CLoadLucasRoomRevampBundle_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CLoadModeBundles_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadModeBundles_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003CLoadSpeechBundle_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadSpeechBundle_003Ed__88(int _003C_003E1__state)
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
	private sealed class _003CLoadSudokuModeBundle_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadSudokuModeBundle_003Ed__58(int _003C_003E1__state)
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
	private sealed class _003CLoadWordProblemModeBundle_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetDeliveryGoogleController _003C_003E4__this;

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
		public _003CLoadWordProblemModeBundle_003Ed__60(int _003C_003E1__state)
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

	public static bool isLanguageDownloadSkiped;

	public static bool isEnableConnectionError;

	public static bool isErrorWhileDownloadDetectedLang;

	public static bool isLanguagePatchBundleDownloading;

	public bool isFirstLaunchDetection;

	public bool IsNoInternetPopupCalled;

	public static bool IsLucasRoomRevampBundleDownloadRequest;

	public static string FishingModeBundleName;

	public static string FunSnowModeBundleName;

	public static string CarModeBundleName;

	public static string SudokuModeBundleName;

	public static string AddSubUFOModeBundleName;

	public static string WordProblemModeBundleName;

	[SerializeField]
	public GameAssetManager gameAssetManager;

	[HideInInspector]
	public bool isDownloadingCanceledForcefully;

	public GameObject loading;

	[HideInInspector]
	public float downloadingProgress;

	private bool waitingOnPermissionResult;

	private GameAssetPack gameAssetPack;

	private AssetPackInfoStatus infoStatus;

	public bool AssetDeliveryError;

	public string englishsound_en;

	public static AssetBundle Current_SoundsBundle;

	public static SoundsDetails objSoundsDetails;

	public static LanguagesBundleNames objLanguagesBundleNames;

	public List<string> lstAssetPackDownloadQueue;

	public static string LucasGardenBundle;

	public static string LucasRoomRevampBundle;

	private string SpeechFounderAssetName;

	public string defaultsMoreAppsBannerName;

	[HideInInspector]
	public bool calledFromInternetError;

	public string FirstLaunchDownloadingBundle => null;

	public bool isCarryForwardAdditionModeDownloaded => false;

	public bool isWordProblemsSubtractionModeDownloaded => false;

	public bool isAdditionPyramidModeDownloaded => false;

	public static event Action<bool> OnLucasGardenBundleDownload
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

	public static event Action<bool> OnLucasRoomRevampBundleDownload
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

	public static event Action<string> OnDownloadAssetBundle
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

	public static event Action<float> MyDownloadProgress
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

	public static event Action<string> OnDownloadSpeechAssetBundle
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

	public static event Action<bool> OnBannerBundleDownloadStatus
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

	public static string GetAWSSoundURL(string langCode)
	{
		return null;
	}

	public static bool IsNewLanguage(string langCode)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void ParseSoundsDetailsFile()
	{
	}

	public static AudioClip LoadAudioFromAssetBundle(string _audioClip)
	{
		return null;
	}

	private void ParseLanguagesBundleNamesXML()
	{
	}

	private void LoadSoundBundle()
	{
	}

	private void LoadPatchSoundBundle()
	{
	}

	public void SetAssetPackInQueueForDownload(string assetPackName)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadEnglishSound_En_003Ed__50))]
	public IEnumerator LoadEnglishSound_En()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadLucasGardenBundle_003Ed__52))]
	public IEnumerator LoadLucasGardenBundle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadLucasRoomRevampBundle_003Ed__54))]
	public IEnumerator LoadLucasRoomRevampBundle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadModeBundles_003Ed__55))]
	public IEnumerator LoadModeBundles()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadFunSnowModeBundle_003Ed__56))]
	public IEnumerator LoadFunSnowModeBundle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadCarModeBundle_003Ed__57))]
	public IEnumerator LoadCarModeBundle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadSudokuModeBundle_003Ed__58))]
	public IEnumerator LoadSudokuModeBundle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAddSubUFOModeBundle_003Ed__59))]
	public IEnumerator LoadAddSubUFOModeBundle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadWordProblemModeBundle_003Ed__60))]
	public IEnumerator LoadWordProblemModeBundle()
	{
		return null;
	}

	public void CacheOrDownloadSoundAssetsCall(string assetName, bool isfromButtonClick = false, string countryCode = "")
	{
	}

	public void CallOnCloseEventOnNointernet()
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadOrLoadSoundBundle_003Ed__69))]
	private IEnumerator DownloadOrLoadSoundBundle(string assetName, string tempHashString)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadSoundsBundles_003Ed__71))]
	private IEnumerator DownloadSoundsBundles()
	{
		return null;
	}

	private void Update()
	{
	}

	private void DestoryCurrentDownloadingGameAssetPack(ref GameAssetPack _gameAssetPack)
	{
	}

	public void SetAssetPackForDownload(string assetPackName, bool isSingleAssetBundlePack)
	{
	}

	private void SetAssetDownloadStatus()
	{
	}

	private void StartDownload()
	{
	}

	public void PermissionResult(bool allow)
	{
	}

	private void SetupDownloading()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadAssetBundleCoroutine_003Ed__79))]
	public IEnumerator LoadAssetBundleCoroutine(PlayAssetBundleRequest bundleRequest, string assetBundleName, Action<PlayAssetBundleRequest, bool> callback)
	{
		return null;
	}

	private void UpdateDownloading()
	{
	}

	private void SetReady()
	{
	}

	private void UpdatePending()
	{
	}

	private void SetupError()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSpeechBundle_003Ed__88))]
	public IEnumerator LoadSpeechBundle()
	{
		return null;
	}

	public bool IsSpeechBundleDownloaded()
	{
		return false;
	}

	public AudioClip GetAssetBundleSoundForSpeech(string SoundName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadBannerBundle_003Ed__95))]
	public IEnumerator LoadBannerBundle()
	{
		return null;
	}

	public void InvokeDownloadProgressEvent(float progressPercent)
	{
	}

	public Sprite GetAssetBundleImageForBanner(string BannerName)
	{
		return null;
	}

	public static byte[] ObjectToByteArray(object obj)
	{
		return null;
	}

	public void CheckForInternetContinuous()
	{
	}
}
