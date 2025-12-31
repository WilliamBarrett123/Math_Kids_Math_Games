using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	public string dragDropValue;

	public int Questioncount;

	public bool isMatched;

	private Transform SelectedObj;

	public static event Action<GameObject, GameObject, bool> OnResultSuccessfully
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

	public static event Action<GameObject, GameObject> OnResultWrong
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

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnDrop(PointerEventData eventData)
	{
	}

	public void PostObjectMatched(Draggable DragStartObj)
	{
	}
}
