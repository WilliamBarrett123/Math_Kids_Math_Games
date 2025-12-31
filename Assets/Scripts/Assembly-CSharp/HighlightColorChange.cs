using UnityEngine;

public class HighlightColorChange : MonoBehaviour
{
	[SerializeField]
	private Color defaultColor;

	[SerializeField]
	private Color SettingColor;

	[SerializeField]
	private Color SettingColor_New;

	public static HighlightColorChange Instance;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}
}
