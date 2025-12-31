using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberType : MonoBehaviour
{
	private string SelectType;

	public GameObject EnSelect;

	public GameObject ARSelect;

	public GameObject EnUnselect;

	public GameObject ARUnselect;

	[SerializeField]
	private GameObject maskContainer;

	[SerializeField]
	private GameObject directionArrow;

	[SerializeField]
	private GameObject blackBg;

	[SerializeField]
	private List<Text> NumList;

	[SerializeField]
	private List<Text> QuesMark;

	private bool isHelpPopUp;

	private bool isfromenable;

	[SerializeField]
	private RectTransform _parentSection;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void LoadDigits()
	{
	}

	public void ArabicOnGameplay()
	{
	}

	public void EnglishOnGameplay()
	{
	}

	public void onCloseBtn()
	{
	}

	private void CheckForNumType(string NumType)
	{
	}

	private void OnDisable()
	{
	}
}
