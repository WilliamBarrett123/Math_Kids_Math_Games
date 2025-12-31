using UnityEngine;
using UnityEngine.UI;

public class EnglishToCurrentLocaleTextConvert : MonoBehaviour
{
	private Font defaultFont;

	private Text thisText;

	[SerializeField]
	private bool isChangeFont;

	[SerializeField]
	private string EnglishNumber;

	[SerializeField]
	private bool tamilAdjustmentReuired;

	[SerializeField]
	private int requiredFontSize;

	private Locale current_locale;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void onLocalizationChanged()
	{
	}

	private void OnLocaleChanged(Locale locale)
	{
	}

	public void mainscreennumberchange()
	{
	}
}
