using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectScrollObject : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	public ScrollRect itemScrollbar;

	public RectTransform ScrollContent;

	public float Row_ID;

	public float TotalNoOFRow;

	public bool isUseExtensionMethod;

	public void OnSelect(BaseEventData eventData)
	{
	}

	private void Update()
	{
	}

	public void OnScrollToCurrentItem()
	{
	}
}
