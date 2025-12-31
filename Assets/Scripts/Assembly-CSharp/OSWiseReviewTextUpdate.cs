using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class OSWiseReviewTextUpdate : MonoBehaviour
{
	private Font defaultFont;

	[SerializeField]
	private string txtAndroidID;

	[SerializeField]
	private string txtIOSID;

	[SerializeField]
	private string txtAmazonID;

	[SerializeField]
	private string txtWindowID;

	[SerializeField]
	private string otherLanguageID;

	private string txtDefaultID;

	private Text thisText;

	private void Awake()
	{
	}

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
