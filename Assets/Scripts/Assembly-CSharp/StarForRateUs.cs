using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class StarForRateUs : Singleton<StarForRateUs>, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	public int curr_Star;

	private bool isdown;

	[SerializeField]
	private GameObject starContainer;

	public static event Action<int> OnClickEvent
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

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void CallOnClickAfterDelay()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}
}
