using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using UnityEngine;

public class GameDataManager : Singleton<GameDataManager>
{
	[CompilerGenerated]
	private sealed class _003COnResetData_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameDataManager _003C_003E4__this;

		private List<string> _003CFileNameList_003E5__2;

		private WaitForSeconds _003CPointTwo_003E5__3;

		private int _003Clength_003E5__4;

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
		public _003COnResetData_003Ed__28(int _003C_003E1__state)
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

	public int stickerResetHours;

	private XDocument xDocUserData;

	public static XDocument StudentData;

	[HideInInspector]
	private bool _IsRateUsFlowEnable;

	private int CurrentGameVersionCode;

	public int CurrentAPIVersion;

	private int getLastVersionCode;

	public bool IsRateUsFlowEnable => false;

	public bool IsNativeShareEnable => false;

	public static event Action OnLoadUser
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

	private void UpdateNewTagPrefrenceForNewUser()
	{
	}

	private void OnEnable()
	{
	}

	private static int getSDKInt()
	{
		return 0;
	}

	private static string getSDKVersionString()
	{
		return null;
	}

	private void SetPatchDateAfterLoadUserData()
	{
	}

	private void PatchReviewFlowData()
	{
	}

	public void ClearMemory()
	{
	}

	private void UpdateExistingPrefsValue(string FileName, string PrefName, string NewValue, bool IsCurrentFile = false)
	{
	}

	private void UpdateLetsLearnPreferenceValue(string FileName, bool IsCurrentFile = false)
	{
	}

	private void OnDisable()
	{
	}

	private void OnEditUserDetails(string newXmlName, string OldXmlName)
	{
	}

	private void OnDownloadAssetBundle(string bundlename)
	{
	}

	private void OnLucasRoomRevampBundleDownload(bool IsDownloaded)
	{
	}

	private void CheckForLastOpenedDate()
	{
	}

	[IteratorStateMachine(typeof(_003COnResetData_003Ed__28))]
	private IEnumerator OnResetData()
	{
		return null;
	}

	private void DeleteOldData(string user)
	{
	}

	private void InUserDeleteThisElements(string FileName, string ElementName)
	{
	}

	private DateTime GetCurrentDateTime()
	{
		return default(DateTime);
	}

	public void OnLoadUserData()
	{
	}

	private void CopyOldDataToNewXMl(string FileName, string OldElementToAdd, string NewElementToAdd)
	{
	}

	private void DoCheckPreviousData()
	{
	}

	private void AddShowGameplayHintElement(string FileName, string NewElementToAdd, bool IsCurrentFile = false, bool IsStringType = false, string isDefaultTrue = "")
	{
	}

	private void AddNewCertificates(string FileName)
	{
	}

	private void UpdateStickersParentForNewFlow(string FileName, bool IsCurrentFile = false)
	{
	}

	private void SetMinOneModePrefs(string FileName, List<string> listOfPrefs, bool IsCurrentFile = false)
	{
	}

	private void OnCheckOldPrefs()
	{
	}

	private void IsPlayerPrefs(string Key, bool ISString = false)
	{
	}

	public void SetPrefsValue(string PrefsName, string Value)
	{
	}

	public static int GetPrefsValueInt(string PrefsName)
	{
		return 0;
	}

	public static string GetPrefsValueString(string PrefsName, string Default = "1-10")
	{
		return null;
	}

	public void OnCreatDefaultStudentFile()
	{
	}

	public void LoadCurrentStudentData()
	{
	}

	private void userCertificateDataload()
	{
	}

	private void OnFireLoadUserEvent()
	{
	}

	private void ResetIsChangeUserCalled()
	{
	}

	public void CreateNewStudent(string FileName)
	{
	}

	public bool CreateDataXML(string path, string fileName, bool doOverrightForced, string DefaultFileName = "Child 1")
	{
		return false;
	}

	private void OnSetOldReportDataToNew(XDocument xdoc)
	{
	}

	public void SaveStudentData()
	{
	}

	public void SaveUserData()
	{
	}

	public void OnWriteReportData(string Equation, string ModeName, int Retry, string SubMode)
	{
	}

	public void OnDeleteXml(string FileName)
	{
	}

	public void LoadFirstUserAfterDeleteSelected(string UserName)
	{
	}

	public int CheckUsersCount()
	{
		return 0;
	}

	public bool IsStudentAddAlready(string EnterName)
	{
		return false;
	}

	public void ToSetBoolValuesOfUsers()
	{
	}

	public List<string> LoadCreatedUserDataFromAddUser()
	{
		return null;
	}

	public void OnAddNewUser(string StudentName, bool IsCurrentActive = false)
	{
	}

	private void OnDestroy()
	{
	}

	public static XElement[] XmlQueryForGetReport(string TypeOfselection)
	{
		return null;
	}

	public List<XElement> GetMathsdatafromXml()
	{
		return null;
	}

	public static int GetElementCount(string EleName)
	{
		return 0;
	}

	public static XElement[] GetToyArrayData(string Element, string ElementChild)
	{
		return null;
	}

	public void DeleteReportCardData()
	{
	}

	public void AddStampIntoXml(string ImageName, string SelectedStampObjectName)
	{
	}

	public void AddGiftsIntoXml(string Toyname)
	{
	}

	public void AddStickersIntoXml(string matchvalue, float x, float y, string Tagretname)
	{
	}

	private void Add_CertificateData()
	{
	}

	private void addIncrementCertificateData(string FileName, string NewElementToAdd, string id, string completeCount, bool IsCurrentFile = false)
	{
	}

	private void addNoneIncrementCertificateData(string FileName, string NewElementToAdd, string id, string completeCount, bool IsCurrentFile = false)
	{
	}

	public XElement[] getCurrentChildElements()
	{
		return null;
	}

	public void updateCertificateDataInStudentData(string id, string completeDate, string completeCount)
	{
	}
}
