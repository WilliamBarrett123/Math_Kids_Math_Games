using System.Collections.Generic;
using UnityEngine;

public class AddEditUserPopUp : Singleton<AddEditUserPopUp>
{
	[HideInInspector]
	public string CurrentStudentName;

	public GameObject OptionSelection;

	public GameObject HintImage;

	public static List<string> StudentName;

	[SerializeField]
	private GameObject btnClose;

	[SerializeField]
	private GameObject btnShare;

	[SerializeField]
	private GameObject ImageShareLineShadow;

	[SerializeField]
	private GameObject textShare;

	private GameObject Container;

	private int TotalChildUserCount;

	public GameObject Addbtn;

	public bool isAddUserPop;

	public GameObject Text_maxLimit;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void ChangeForText()
	{
	}

	public void OnShareBtn(Transform thisGameObject)
	{
	}

	private void OnloadRowData()
	{
	}

	public void RemoveFromSelectableList()
	{
	}

	private void AddSelectableInListForNavigation()
	{
	}

	private void ClearSelectableList()
	{
	}

	private void AddExplicitNavigation(Transform TempTransform, string SelectedObj, int Index = 0, int TotalCount = 0)
	{
	}

	private void FindChildObject(Transform parentTransform, string ChildName, float TotalCount, float RowID)
	{
	}

	private void AddSelectScrollComponent(GameObject selectableGameobject, float TotalCount, float RowID)
	{
	}

	private void AddIntoSelectableList(GameObject selectableGameobject)
	{
	}

	private void disableISNewUserGenerate()
	{
	}

	public void OnCreateBtnPressed()
	{
	}

	private bool OnCheckFieldPresent()
	{
		return false;
	}

	public void SetScrollPosition(bool checkFromNew = false)
	{
	}

	private void DoAddbtnVisible()
	{
	}

	private void InstantiateStudentRow()
	{
	}

	public void OnDeleteEnteredInputText()
	{
	}

	public void DestroyHelp()
	{
	}

	public void OnAddBtnClick()
	{
	}

	public void SetUserAfterDelete()
	{
	}

	public void OnClosebtnClick()
	{
	}
}
