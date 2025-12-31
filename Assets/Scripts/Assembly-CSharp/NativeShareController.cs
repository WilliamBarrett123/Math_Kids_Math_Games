using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NativeShareController : Singleton<NativeShareController>
{
	public enum nativeSharePlace
	{
		settingScreen = 0,
		quickFacts = 1,
		ourMission = 2,
		whyItsFree = 3,
		addEditUser = 4,
		kidsEducation = 5,
		ourStory = 6,
		certificate = 7,
		workSheet = 8
	}

	[CompilerGenerated]
	private sealed class _003CShareWithImage_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NativeShareController _003C_003E4__this;

		public string filePath;

		private string _003CTitle_003E5__2;

		private string _003CSubject_003E5__3;

		private string _003CMessage_003E5__4;

		private string _003CCapturedImage_Path_003E5__5;

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
		public _003CShareWithImage_003Ed__22(int _003C_003E1__state)
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

	private bool IsAppInstalled;

	private string selectedSharingOption;

	private string FBShareText;

	private string SharingFrom;

	private string WhatsappShareText;

	private string TwitterShareText;

	private string GmailShareText_1;

	private string GmailShareText_2;

	private string GmailShareText_3;

	private string GeneralShareText;

	private string shareSpritename;

	private List<string> _messageTexts;

	[SerializeField]
	private Texture2D our_StoreImageText;

	private Texture2D shareImage;

	[HideInInspector]
	public string nativeShareButtonName;

	private string buildIdentifier;

	private bool CheckForAppInstalled(string bundleID)
	{
		return false;
	}

	public void onNativeShare(string ApplicationName, nativeSharePlace screenName, string filePath = "")
	{
	}

	private void onAndroidShare(string ApplicationName, string filePath = "")
	{
	}

	private void ShareData(string PackageName, string Message)
	{
	}

	public void onNativeShareWithImage(string filePath = "")
	{
	}

	[IteratorStateMachine(typeof(_003CShareWithImage_003Ed__22))]
	private IEnumerator ShareWithImage(string filePath = "")
	{
		return null;
	}

	private void setSharingString(nativeSharePlace shareFromScreen)
	{
	}

	public void PrintButtonClicked(string orientation, string screenType, string filePath = "")
	{
	}

	private string StoreImageAndReturnFilePath(string fileName = "")
	{
		return null;
	}

	private void clearShareImage()
	{
	}

	public static Texture2D LoadImageFromFilePath(string filePath)
	{
		return null;
	}
}
