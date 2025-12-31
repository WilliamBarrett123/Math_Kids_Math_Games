using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CustomTextScript : MonoBehaviour
{
	[SerializeField]
	private bool forceUpperCase;

	[SerializeField]
	private bool forceAlternateEnglishText;

	[SerializeField]
	private string AlternateEnglishText;

	public string txtID;

	private Text thisText;

	private Font defaultFont;

	[SerializeField]
	private bool isnepalitohindi;

	[SerializeField]
	private float delayedLoad;

	public bool iswrappingfixrequired;

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

	private void stringconversion()
	{
	}
}
