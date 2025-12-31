using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class RateUsUpdateText : MonoBehaviour
{
	private Font defaultFont;

	public string txtID;

	private Text thisText;

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
}
