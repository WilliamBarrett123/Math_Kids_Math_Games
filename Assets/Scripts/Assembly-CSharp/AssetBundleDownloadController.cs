using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class AssetBundleDownloadController : Singleton<AssetBundleDownloadController>
{
	[CompilerGenerated]
	private sealed class _003CGetAssetBundleFromCache_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleDownloadController _003C_003E4__this;

		public string assetName;

		public string baseURL;

		private string _003CtempHashString_003E5__2;

		private Hash128 _003ChashString_003E5__3;

		private UnityWebRequest _003Cwww_003E5__4;

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
		public _003CGetAssetBundleFromCache_003Ed__2(int _003C_003E1__state)
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
	private sealed class _003CGetOrDownloadAssetBundleFromS3_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleDownloadController _003C_003E4__this;

		public string assetName;

		public string baseURL;

		private string _003CtempHashString_003E5__2;

		private Hash128 _003ChashString_003E5__3;

		private UnityWebRequest _003Cwww_003E5__4;

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
		public _003CGetOrDownloadAssetBundleFromS3_003Ed__3(int _003C_003E1__state)
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
	private sealed class _003CShowProgress_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleDownloadController _003C_003E4__this;

		public int _downloadSize;

		public UnityWebRequest www;

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
		public _003CShowProgress_003Ed__8(int _003C_003E1__state)
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
	public int downloadSize;

	private bool isBreakProgress;

	private float kb;

	private float percentage;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CGetAssetBundleFromCache_003Ed__2))]
	public IEnumerator GetAssetBundleFromCache(string assetName, string baseURL)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetOrDownloadAssetBundleFromS3_003Ed__3))]
	public IEnumerator GetOrDownloadAssetBundleFromS3(string assetName, string baseURL)
	{
		return null;
	}

	private AssetBundle DownloadAssetBundle(string assetName, UnityWebRequest www, Hash128 hashString)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowProgress_003Ed__8))]
	private IEnumerator ShowProgress(UnityWebRequest www, string assetName, int _downloadSize)
	{
		return null;
	}

	public string IsAssetBundleExistsInCached(string bundleName)
	{
		return null;
	}
}
