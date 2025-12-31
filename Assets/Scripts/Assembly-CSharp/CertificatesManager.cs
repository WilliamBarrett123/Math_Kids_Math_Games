using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CertificatesManager : Singleton<CertificatesManager>
{
	[Serializable]
	public class Certificates
	{
		public int id;

		public string certificateType;

		public bool isIncrement;

		public int maxCount;

		public string assetBundleName;

		public bool isBundleNewAvaiable;

		public bool isBundleDownloaded;

		public bool isStartBundleDownload;

		public Certificates(int id, string certificateType, string assetBundleName, bool isIncrement, int maxCount, bool isBundleNewAvaiable = true, bool isBundleDownload = false)
		{
		}
	}

	[Serializable]
	public class UserCertificatesData
	{
		public int id;

		public string completeDate;

		public string completeCount;

		public bool isUpdated;

		public UserCertificatesData(int id, string completeDate, string completeCount)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public int assetBundleId;

		public string assetName;

		internal bool _003CDownloadAssetFromServer_003Eb__0(Certificates f)
		{
			return false;
		}

		internal bool _003CDownloadAssetFromServer_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownloadAssetFromServer_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int assetBundleId;

		public bool isFromPatch;

		public CertificatesManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		private int _003CFindIndexCurrent_003E5__2;

		private int _003CbundleId_003E5__3;

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
		public _003CDownloadAssetFromServer_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CFillCertificateDownloadBundleFromCache_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CertificatesManager _003C_003E4__this;

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
		public _003CFillCertificateDownloadBundleFromCache_003Ed__38(int _003C_003E1__state)
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

	[HideInInspector]
	public static bool IsCertificateModuleEnable;

	public List<Certificates> lstCertificates;

	[HideInInspector]
	public List<UserCertificatesData> lstUserCertificatesData;

	[HideInInspector]
	public int downloadSize;

	[HideInInspector]
	public float downloadingProgress;

	[HideInInspector]
	public bool isOnceParentOpen;

	private string BundlePackURL;

	private Dictionary<string, AssetBundle> dictDownloadedBundles;

	public int currentlyZoomCertificate;

	public int[] freeCertificateNumber;

	[HideInInspector]
	public int certificateSessionCount;

	private int[] InstaInspirationShowCountArr;

	[HideInInspector]
	public bool isAnyCertificateComplete;

	private bool isDirectUnlockCertificate;

	private int DefaultCertificateBundle;

	private Sprite[] lstOfWorksheetSprite;

	[SerializeField]
	private Sprite[] AssignCertificatesBytesFile;

	public List<string> lstManuallyDownloaded;

	public static event Action<int, bool> OnCertificateDownloadCompleted
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

	private void OnEnable()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDisable()
	{
	}

	public bool checkCertificateFree(int val)
	{
		return false;
	}

	public bool checkInstaPopupShowOrNot(int val)
	{
		return false;
	}

	private void Start()
	{
	}

	public void updteSessionCount()
	{
	}

	public bool isShowInstaInpirationPopup()
	{
		return false;
	}

	public void setStudentCertificateData()
	{
	}

	public bool isCertificateUnlock(int certificateID)
	{
		return false;
	}

	public string getCertificateName(int certificateID)
	{
		return null;
	}

	public string CertificateUnlockDate(int certificateID)
	{
		return null;
	}

	public string getDefaultCertificateMaxCount(int certificateID)
	{
		return null;
	}

	public string getCertificateCompleteCount(int certificateID)
	{
		return null;
	}

	public bool isCertificateBundleDownloaded(int certificateID)
	{
		return false;
	}

	public bool isCertificateBundleDownloading(int certificateID)
	{
		return false;
	}

	public void updateCertificateStauts(int certificateID, string value = "", bool isFree = false)
	{
	}

	private void updateXML()
	{
	}

	[IteratorStateMachine(typeof(_003CFillCertificateDownloadBundleFromCache_003Ed__38))]
	private IEnumerator FillCertificateDownloadBundleFromCache()
	{
		return null;
	}

	public Sprite getSpriteFromDownloadAsset(int CurrentCertificateId)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDownloadAssetFromServer_003Ed__40))]
	public IEnumerator DownloadAssetFromServer(int assetBundleId, bool isFromPatch = false)
	{
		return null;
	}

	private void addValueInPref(int Val)
	{
	}

	private List<string> RemoveDuplicateValueFromString(string str)
	{
		return null;
	}

	private string ListOfCertificateBundlePref(List<string> lst)
	{
		return null;
	}

	public void setParentFlag(bool val)
	{
	}
}
