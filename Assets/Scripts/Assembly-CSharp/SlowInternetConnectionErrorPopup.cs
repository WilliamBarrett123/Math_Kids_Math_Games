using UnityEngine;
using UnityEngine.UI;

public class SlowInternetConnectionErrorPopup : MonoBehaviour
{
	[HideInInspector]
	public bool isHideWaitBtn;

	[SerializeField]
	private GameObject btn_Wait;

	[SerializeField]
	private GameObject btn_Skip;

	[SerializeField]
	private GameObject btnClose;

	[SerializeField]
	private Text txtTitle;

	private string DeviceLanguage;

	private Font requiredFont;

	private void Start()
	{
	}

	public void AutoCloseScreen()
	{
	}

	public void OnSkipButtonClick(GameObject currentItem)
	{
	}

	public void OnWaitButtonClick(GameObject currentItem)
	{
	}

	private void onBackClick()
	{
	}

	private void OnDisable()
	{
	}
}
