using UnityEngine;
using UnityEngine.UI;

public class worksheetScreen : Singleton<worksheetScreen>
{
	public GameObject worksheetContainer;

	public int totalworksheets;

	private bool isDownloadRhymesBundle;

	private string downloadingworksheetName;

	private Text worksheetBundlePercentageText;

	private Transform currentDownloadWorksheetObj;

	private Transform currentDownloadButtontransform;

	[HideInInspector]
	public string comeFromWhichButontoParentSection;

	[HideInInspector]
	private GameObject printworksheetObj;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}

	public void onDownloadButtonClick(GameObject currentButton)
	{
	}

	public void startDownloadworksheet()
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

	public void onCloseClick()
	{
	}

	public void onPintrestBtnClick()
	{
	}

	private void showPintrestConformPopup()
	{
	}

	private void onClose()
	{
	}
}
