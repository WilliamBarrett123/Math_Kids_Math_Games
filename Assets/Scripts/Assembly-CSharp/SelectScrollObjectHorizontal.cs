using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectScrollObjectHorizontal : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	public ScrollRect itemScrollbar;

	public RectTransform ScrollContent;

	public float Row_ID;

	public float TotalNoOFRow;

	public bool isFromParentGames;

	public bool isUseStaticPositions;

	public Vector3 ScrollPosition;

	public bool IsPagingMoreApps;

	public bool isnavHelp;

	public bool isShoppopupKidsgames;

	public void OnSelect(BaseEventData eventData)
	{
	}

	private void Update()
	{
	}
}
