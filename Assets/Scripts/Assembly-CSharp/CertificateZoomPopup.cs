using UnityEngine;

public class CertificateZoomPopup : Singleton<CertificateZoomPopup>
{
	[SerializeField]
	private Transform btn_close;

	[SerializeField]
	private Transform EditPen;

	[SerializeField]
	private Transform InputField;

	[HideInInspector]
	public string comeFromWhichButontoParentSection;

	public GameObject certificateContainer;

	public GameObject btnShare;

	public GameObject btnPrint;

	[HideInInspector]
	private GameObject SpawnObject;

	private string CapturedImage_Path;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void onBacktnClick()
	{
	}

	public void onBtnPrintClick(GameObject BtnObject)
	{
	}

	private void showGrowUpScreen()
	{
	}

	public void printCertificate()
	{
	}

	public void onBtnShareClick(GameObject BtnObject)
	{
	}

	public void shareCertificate()
	{
	}

	private void SetKeyboardNavigation()
	{
	}

	private void AddIntoSelectableList(GameObject selectableGameobject, bool IsAddInDefault = false)
	{
	}

	private void SetButtonNavigationsDirections(Transform TempTransform)
	{
	}
}
