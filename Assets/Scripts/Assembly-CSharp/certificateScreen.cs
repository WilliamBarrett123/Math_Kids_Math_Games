using UnityEngine;
using UnityEngine.UI;

public class certificateScreen : Singleton<certificateScreen>
{
	public GameObject certificateContainer;

	public int totalCertificates;

	private bool isDownloadRhymesBundle;

	private string downloadingCertificateName;

	private int ShareOrPrint_ThisCertificate;

	private Text CertificateBundlePercentageText;

	private Transform currentDownloadCertyObj;

	private Transform currentDownloadButtontransform;

	[HideInInspector]
	public string comeFromWhichButontoParentSection;

	private GameObject CertificatePopup;

	private string CapturedImage_Path;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void onDownloadButtonClick(GameObject currentButton)
	{
	}

	public void startDownloadCertificate()
	{
	}

	private void OnCertificateBundleDownloadCompletedEvent(int CurrentId, bool isSuccessfullyDownload)
	{
	}

	private void DisplayDownloadingProgressTextForRhymesBundle()
	{
	}

	private bool isCanDownloadPopup()
	{
		return false;
	}

	public void onShareButtonClick(GameObject currentButton)
	{
	}

	public void onShareParentVerificationSuccess()
	{
	}

	private void removeScreenShotPopup()
	{
	}

	public void onPrintButtonClick(GameObject currentButton)
	{
	}

	private void showGrowUpScreen()
	{
	}

	public void onPrintParentVerificationSuccess()
	{
	}

	public void onZoomButtonClick(GameObject currentButton)
	{
	}

	private GameObject LoadPrefabFor_ShareOrPrint()
	{
		return null;
	}
}
