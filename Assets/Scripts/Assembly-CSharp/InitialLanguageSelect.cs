using UnityEngine;
using UnityEngine.UI;

public class InitialLanguageSelect : MonoBehaviour
{
	private string MyAssetName;

	private string DeviceSystemLanguage;

	[SerializeField]
	private Text HeadingLocalized;

	[SerializeField]
	private Text HeadingEnglish;

	[SerializeField]
	private Text EnglishText;

	[SerializeField]
	private Text OtherText;

	[SerializeField]
	private GameObject btnContinue;

	[SerializeField]
	private Transform LeftBox;

	[SerializeField]
	private Transform RightBox;

	private string TappedItemCode;

	private bool playaudio;

	public static bool IsALDCharacterShowLanguage => false;

	private void OnEnable()
	{
	}

	private void localeChange(Locale locale)
	{
	}

	private void setAllTexts()
	{
	}

	public void DeviceLanguageSelect(Toggle btn)
	{
	}

	public void EnglishlanguageSelect(Toggle btn)
	{
	}

	private void ContinueTextSet()
	{
	}

	public void OnContinueBtnClick(Transform thisGameObject)
	{
	}

	private void OnDisable()
	{
	}
}
