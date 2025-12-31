using UnityEngine;
using UnityEngine.UI;

public class langaugesWiseHeightChange : MonoBehaviour
{
	[SerializeField]
	private int HindiHeight;

	[SerializeField]
	private int MarthiHeight;

	[SerializeField]
	private int GermanHeight;

	[SerializeField]
	private int SpanishHeight;

	[SerializeField]
	private int FrenchHeight;

	[SerializeField]
	private int PortugueseHeight;

	[SerializeField]
	private int RussianHeight;

	private Text thisText;

	private RectTransform thisTransform;

	private void Start()
	{
	}

	private void OnLocaleChanged(Locale locale)
	{
	}
}
