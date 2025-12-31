using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LocaleText_uGUI : MonoBehaviour
{
	private Font defaultFont;

	public string txtID;

	public float delayedLoad;

	private Text thisText;

	public bool iswrappingfixrequired;

	public bool isEnglishtext;

	[SerializeField]
	private bool isUpdateFont;

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
