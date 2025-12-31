using UnityEngine;

public class LocaleWiseFontSizeUpdate : MonoBehaviour
{
	[SerializeField]
	private bool updateCustomFont;

	[SerializeField]
	private int sizeFont;

	[SerializeField]
	private bool isForParentText;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLocaleChanged(Locale locale)
	{
	}
}
