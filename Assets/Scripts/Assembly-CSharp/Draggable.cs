using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
	public Transform targetObj;

	public Transform SelectedObj;

	private Draggable actualObject;

	private bool isPointDownClick;

	public bool isUsedForClick;

	public bool isDragBegin;

	public bool isReportDataFilled;

	private Vector3 Position;

	public string dragStartValue;

	public string _TempValue;

	public DragObjectPlace _place;

	private float scaleUpVal;

	private float dragOffsetY;

	public bool IsUsedDuplicate;

	public bool IsNoNeedSortingOrder;

	private bool isObjectMoved;

	private Transform stickerTrail;

	private Vector3 Temp_Value;

	private List<DropZone> lstHintObjects;

	public static event Action<GameObject, bool, bool> OnObjectTouchStartEndEvent
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

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	private void OnDragBeginSetObject(Transform DragObj, Vector2 DragPosition)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
