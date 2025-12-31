using UnityEngine;

public class KeyboardNavigationController : Singleton<KeyboardNavigationController>
{
	public static bool isKeyBoardNavigation;

	[SerializeField]
	private GameObject HighlightImage;

	[SerializeField]
	private Transform canvas;

	private Quaternion quaternionZero;

	[HideInInspector]
	public KeyCode ChromReturn;

	public GameObject EventSystem;

	[SerializeField]
	private Texture2D defaultCursor;

	[SerializeField]
	private Texture2D clickCursor;

	[SerializeField]
	private GameObject wifiObject;

	private bool storelastStatus;

	private void Awake()
	{
	}

	public void updateSendNavigationEventsFlag(bool val)
	{
	}

	private void CheckInternetConnection()
	{
	}

	private void DisableWifiButton()
	{
	}

	private void OnDisable()
	{
	}

	public bool isChromeBook()
	{
		return false;
	}

	public void SetHighlightImageForSelectedUI(GameObject SelectedObject)
	{
	}

	private void SetImageRectForHover(RectTransform HighlightImageRect, GameObject SelectedObject)
	{
	}

	public void ResetHighlightImageProperties()
	{
	}

	private void setDefaultCursor()
	{
	}

	private void setClickCurson()
	{
	}
}
