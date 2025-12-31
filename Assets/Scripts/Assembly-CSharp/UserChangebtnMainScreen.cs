using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UserChangebtnMainScreen : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
{
	public static UserChangebtnMainScreen Instance;

	public bool IsBlackBgON;

	public Dropdown DropDownBtn;

	private GameObject Img_BlackBG;

	private List<string> userName;

	private string NewUser;

	private string OldUser;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void LoadUserName()
	{
	}

	private void AddDropDownChildIntoList()
	{
	}

	public void OnDropDown_UserChange(int userIndex)
	{
	}

	public void OnSuccessfulPasswordMatch()
	{
	}

	private void CheckModeButtonAfterDelay()
	{
	}

	private void ResetList()
	{
	}

	public void OnWrongPassword()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	private void PopDropDown()
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void OnEscapedPressed()
	{
	}

	private void EventFireForScreenChangeAfterDelay()
	{
	}

	public void OnBlackBgClick()
	{
	}
}
