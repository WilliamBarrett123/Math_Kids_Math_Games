using UnityEngine;
using UnityEngine.UI;

public class ModifyGrownUpScreen : MonoBehaviour
{
	[SerializeField]
	private Text mainDefaultText;

	[SerializeField]
	private Text childDefaultText;

	[SerializeField]
	private Text[] miniTexts;

	[SerializeField]
	private Text[] mainTexts;

	[SerializeField]
	private GameObject DefaultPanel;

	[SerializeField]
	private GameObject NewPanel;

	private bool playaudio;

	[SerializeField]
	private Toggle defaultoption;

	[SerializeField]
	private Toggle add;

	[SerializeField]
	private Toggle sub;

	[SerializeField]
	private Toggle mul;

	[SerializeField]
	private Text Numbers;

	[SerializeField]
	private Text numbersChild;

	private string systemLanguage;

	private string[] partPass;

	[SerializeField]
	private Transform NumberPad_Panel;

	private void OnEnable()
	{
	}

	private void SetNumber()
	{
	}

	private void Checkforpanel()
	{
	}

	private void SetToggle()
	{
	}

	public void onDefaultSelect(Toggle btn)
	{
	}

	public void onAddSelect(Toggle btn)
	{
	}

	public void onSubSelect(Toggle btn)
	{
	}

	public void onMulSelect(Toggle btn)
	{
	}

	private void OnDisable()
	{
	}

	public void onCloseButtonClick(GameObject currentButton)
	{
	}

	private void onClosePress()
	{
	}
}
