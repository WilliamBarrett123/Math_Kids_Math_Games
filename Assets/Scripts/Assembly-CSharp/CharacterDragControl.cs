using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class CharacterDragControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	protected HappyIdleWalkingLeftActivity happyIdleWalkingleftActivity;

	protected HappyIdleWalkingRightActivity happyIdleWalkingRightActivity;

	protected IdleWalkingLeftActivity idleWalkingLeftActivity;

	protected IdleWalkingRightActivity idleWalkingRightActivity;

	public Ease LineareaseType;

	public float IdleTime;

	public abstract void OnPointerDown(PointerEventData data);

	public abstract void OnDrag(PointerEventData data);

	public abstract void OnPointerUp(PointerEventData data);

	public abstract void OnBeginDrag(PointerEventData eventData);

	public abstract void OnEndDrag(PointerEventData eventData);

	public abstract void SetSpeciFicAnimation(GameObject OnDropItem);

	public abstract void HighLightingtheObject(GameObject thisGameobject, bool ISKILL = false);

	public void SetCharacterWithinBounds(Vector2 viewpos, ICharacter character)
	{
	}

	public void UpdateCanvasOfCharacter(string Name, ICharacter character)
	{
	}

	protected virtual void Update()
	{
	}

	protected abstract void HandleBackGroundScroll();

	protected abstract void HandleCharacterIdleMovement();

	protected abstract void HandleArrowUI();

	protected abstract void CheckingInput();

	protected abstract void CheckingInputMouse();
}
