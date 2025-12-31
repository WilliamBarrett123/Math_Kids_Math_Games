using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Setting_Worksheet : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetWorkSheetForScreens_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Setting_Worksheet _003C_003E4__this;

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
		public _003CSetWorkSheetForScreens_003Ed__44(int _003C_003E1__state)
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

	private string currentActive;

	[SerializeField]
	private bool isCalledWorkSheetFromPopup;

	[SerializeField]
	private Transform tran_WorkSheet;

	[SerializeField]
	private Transform tran_ColoringPage;

	[SerializeField]
	private Transform tran_TopWorkSheet;

	[SerializeField]
	private Transform tran_TopColoringPage;

	[SerializeField]
	private List<GameObject> lstWorkSheetObject;

	private string downloadingworksheetName;

	private Text worksheetBundlePercentageText;

	private Transform currentDownloadWorksheetObj;

	private Transform Temp_CurrentDownload;

	private Transform currentDownloadButtontransform;

	[SerializeField]
	private Selectable sele_Coloring;

	[SerializeField]
	private Selectable sele_WorkSheet1;

	[SerializeField]
	private Selectable sele_WorkSheet4;

	[SerializeField]
	private Selectable sele_ColorSheet1;

	[SerializeField]
	private Selectable sele_ColorSheet4;

	[SerializeField]
	private Selectable sele_Bottom;

	private bool isDownloadRhymesBundle;

	private string packageName;

	private string pageUrl;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void _OnScreenStatusUpdatedEvent(bool isStatus, string screenName)
	{
	}

	private void SelectFirstSelectableWithDelay()
	{
	}

	private void OpenCloseTabSelectionDetails(string currentScreen, bool isOpen, bool isEnableCanvas = true)
	{
	}

	public void onTopPanelButtonClick(GameObject thisGameObject)
	{
	}

	private void openAnimation()
	{
	}

	public void onWorkSheetButtonClick(GameObject thisGameObject)
	{
	}

	public void onColoringPageButtonClick(GameObject thisGameObject)
	{
	}

	public void onPintrestButtonClick(GameObject thisGameObject)
	{
	}

	private void showPintrestConformPopup()
	{
	}

	private void RedirectToPintrestSite()
	{
	}

	public bool openUrl(string packageName, string url)
	{
		return false;
	}

	public void onDownloadButtonClick(GameObject currentButton)
	{
	}

	private void startDownloadworksheet()
	{
	}

	private void OnworksheetBundleDownloadCompletedEvent(int CurrentId, bool isSuccessfullyDownload)
	{
	}

	private void DisplayDownloadingProgressTextForRhymesBundle()
	{
	}

	private bool isCanDownloadPopup()
	{
		return false;
	}

	public void onZoomButtonClick(GameObject currentButton)
	{
	}

	public void onCloseClick(GameObject thisGameObject)
	{
	}

	private void onClose()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	[IteratorStateMachine(typeof(_003CSetWorkSheetForScreens_003Ed__44))]
	private IEnumerator SetWorkSheetForScreens()
	{
		return null;
	}
}
