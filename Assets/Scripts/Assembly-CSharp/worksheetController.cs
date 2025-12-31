using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class worksheetController : Singleton<worksheetController>
{
	[Serializable]
	public class Worksheets
	{
		public int id;

		public string WorksheetType;

		public string assetBundleName;

		public bool isBundleNewAvaiable;

		public bool isBundleDownloaded;

		public bool isStartBundleDownload;

		public Worksheets(int id, string WorksheetType, string assetBundleName, bool isBundleNewAvaiable = true, bool isBundleDownload = false)
		{
		}
	}

	[Serializable]
	public class UserWorksheetsData
	{
		public int id;

		public bool isUpdated;

		public UserWorksheetsData(int id)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public int assetBundleId;

		public string assetName;

		internal bool _003CDownloadAssetFromServer_003Eb__0(Worksheets f)
		{
			return false;
		}

		internal bool _003CDownloadAssetFromServer_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownloadAssetFromServer_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int assetBundleId;

		public bool isFromPatch;

		public worksheetController _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

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
		public _003CDownloadAssetFromServer_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CFillWorksheetDownloadBundleFromCache_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public worksheetController _003C_003E4__this;

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
		public _003CFillWorksheetDownloadBundleFromCache_003Ed__18(int _003C_003E1__state)
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
	public static bool IsWorksheetModuleEnable;

	public List<Worksheets> lstWorksheets;

	[HideInInspector]
	public int downloadSize;

	private string BundlePackURL;

	[HideInInspector]
	public int currentlyZoomWorksheet;

	[SerializeField]
	private bool isLoadWebPImage;

	private Sprite[] lstOfWorksheetSprite;

	public int[] freeWorksheetNumber;

	[SerializeField]
	private Sprite[] AssignWorksheetBytesFile;

	private int DefaultWorksheetBundle;

	public List<string> lstManuallyDownloaded;

	public static event Action<int, bool> OnWorksheetDownloadCompleted
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

	private void Start()
	{
	}

	public string getWorksheetName(int WorksheetID)
	{
		return null;
	}

	public bool isWorksheetBundleDownloaded(int WorksheetID)
	{
		return false;
	}

	public bool isWorksheetBundleDownloading(int WorksheetID)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CFillWorksheetDownloadBundleFromCache_003Ed__18))]
	private IEnumerator FillWorksheetDownloadBundleFromCache()
	{
		return null;
	}

	public Sprite getSpriteFromDownloadAsset(int CurrentWorksheetId)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDownloadAssetFromServer_003Ed__20))]
	public IEnumerator DownloadAssetFromServer(int assetBundleId, bool isFromPatch = false)
	{
		return null;
	}

	public void FillDownloadedWorksheetDataOnOtherScreen(string assetName)
	{
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

	public Sprite getSpriteFromResource(int worksheetNum)
	{
		return null;
	}

	public static TextAsset getTextAssetASWorksheetName(string path)
	{
		return null;
	}
}
