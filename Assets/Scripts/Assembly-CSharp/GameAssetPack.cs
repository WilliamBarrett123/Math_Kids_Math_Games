using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.AssetDelivery;
using Google.Play.Common;
using UnityEngine;

public class GameAssetPack : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAskForCellularDataPermission_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameAssetPack _003C_003E4__this;

		private PlayAsyncOperation<ConfirmationDialogResult, AssetDeliveryErrorCode> _003CasyncOperation_003E5__2;

		private bool _003CpermissionAllow_003E5__3;

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
		public _003CAskForCellularDataPermission_003Ed__38(int _003C_003E1__state)
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

	private string assetPackName;

	private long assetPackSize;

	private bool isSingleAssetBundlePack;

	private PlayAssetBundleRequest assetBundleRequest;

	private PlayAssetPackRequest assetPackRequest;

	private bool isAssetPackSizeValid;

	private bool isCellularConfirmationActive;

	private bool didApproveCellularData;

	public string AssetPackName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long AssetPackSize
	{
		get
		{
			return 0L;
		}
		private set
		{
		}
	}

	public bool IsSingleAssetBundlePack
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAssetPackSizeValid
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool IsCellularConfirmationActive
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool DidApproveCellularData
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool IsDownloaded()
	{
		return false;
	}

	public void StartDownload()
	{
	}

	public AssetBundle FinishBundleDownload()
	{
		return null;
	}

	public PlayAssetPackRequest FinishPackDownload()
	{
		return null;
	}

	public bool IsDownloadActive()
	{
		return false;
	}

	public AssetDeliveryStatus GetStatus()
	{
		return default(AssetDeliveryStatus);
	}

	public AssetDeliveryErrorCode GetError()
	{
		return default(AssetDeliveryErrorCode);
	}

	public float GetDownloadProgress()
	{
		return 0f;
	}

	private void Awake()
	{
	}

	public void InitializeAssetPack(string newAssetPackName, bool isSingleBundlePack)
	{
	}

	private void StartAssetPackSizeQuery()
	{
	}

	public void RequestCellularDataDownload()
	{
	}

	[IteratorStateMachine(typeof(_003CAskForCellularDataPermission_003Ed__38))]
	private IEnumerator AskForCellularDataPermission()
	{
		return null;
	}
}
