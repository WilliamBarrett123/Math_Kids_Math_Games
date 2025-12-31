using UnityEngine;
using UnityEngine.EventSystems;

public class QuickFactsScrollManager : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler
{
	public GameObject circlePanel;

	public Sprite circleEnable;

	public Sprite circleDisable;

	private bool directionChangedThroughSwipe;

	private bool IsAnimationStarted;

	private int direction;

	private int circleEnableCount;

	private Vector2 touchDownPos;

	private Vector2 SwipeMovePosition;

	private void Start()
	{
	}

	private void CallSwiping()
	{
	}

	private void animComp()
	{
	}

	void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
	{
	}

	void IDragHandler.OnDrag(PointerEventData eventData)
	{
	}

	private void OnSwipe(int SwipeDirection)
	{
	}

	private void StartAnimation()
	{
	}

	private void resetAnimBool()
	{
	}
}
