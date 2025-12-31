using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StudentDetailSet : MonoBehaviour
{
	public Toggle toggle;

	public Image IMG_DeleteBtn;

	public static string NameThtNeedEdit;

	private bool IsfromStart;

	public static event Action<string, bool> OnChangeUser
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEditUserDetails(string newXmlName, string OldXmlName)
	{
	}

	private void Start()
	{
	}

	private void DisableIsFromStart()
	{
	}

	public void OnBoolChange(Toggle IsonToggle)
	{
	}

	private void checkOtherToggle()
	{
	}

	public void OnEditBtnClicked(GameObject btnParent)
	{
	}

	public void DeleteUserAndData(GameObject objParent)
	{
	}
}
