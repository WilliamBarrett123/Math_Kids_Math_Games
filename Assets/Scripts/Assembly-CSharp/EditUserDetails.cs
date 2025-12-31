using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EditUserDetails : MonoBehaviour
{
	public InputField InputField;

	private string NewName;

	private string OldName;

	public GameObject AlreadyAddText;

	public static event Action<string, string> OnEditUserDetails
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public void OnInputFieldText()
	{
	}

	private void OnEnable()
	{
	}

	private char MyValidate(char charToValidate)
	{
		return '\0';
	}

	public void OnSaveBtnClick()
	{
	}

	public void OnStartField(GameObject btnAddObj)
	{
	}

	private void ToastAlreadyAddText()
	{
	}

	private void ToastAlreadyAddTextDisable()
	{
	}

	private void EditRowName(string EditedName)
	{
	}

	public void OnClearBtnPressed()
	{
	}

	public void OnBackButtonPressed()
	{
	}
}
