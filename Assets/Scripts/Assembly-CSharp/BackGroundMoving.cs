using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BackGroundMoving : MonoBehaviour
{
	[SerializeField]
	[Header("ScrollRect Component")]
	private ScrollRect _ScrollRect;

	[SerializeField]
	private RectTransform _Layer4RectTransform;

	[SerializeField]
	private RectTransform _Layer2RectTransform;

	[SerializeField]
	private RectTransform _Layer1RectTransform;

	[SerializeField]
	private RectTransform bgLayer;

	private Camera _CameraMain;

	private Vector2 ContentBounds;

	private Vector2 StartPos;

	private Vector2 offset;

	private Ease LinearEaseType;

	private GameObject DraggedObject;

	private RectTransform DraggedObjectRecTransform;

	private RaycastHit2D HitObject;

	private float DistanceY;

	private float DistanceX;

	private float MainCanvasHeight;

	private float HitObjectSize;

	private RectTransform HitObjectRecttraform;

	private static ScrollHandler scrollHandler;

	private Vector2 CanvasreferenceResolution;

	private bool canMoveBackGround;

	private CharacterName lastCharacterName;

	private float lastActivityPosition;

	private void OnEnable()
	{
	}

	private void FixUnknownCanvasLayers(GameObject parent)
	{
	}

	private void TraverseChildren(Transform current)
	{
	}

	private bool IsUnknownSortingLayer(int sortingLayerID)
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnResolutionChanged(Vector2 resolution)
	{
	}

	public void OnValueChanged(Vector2 a)
	{
	}

	public void OnPointerDown(BaseEventData data)
	{
	}

	public void ObjectBeginDragging(BaseEventData data)
	{
	}

	public void ObjectDrgging(BaseEventData data)
	{
	}

	public void ObjectEndDrag(BaseEventData data)
	{
	}

	private void SetObjectDragWithinBounds(Vector2 pos)
	{
	}

	private void SetpositionAndLayer()
	{
	}

	private void SeeTheObstacles()
	{
	}

	public void OnBackButtonPressed()
	{
	}

	private void OnCloseLucasgarden()
	{
	}

	public static void EnableDisbaleScrollHandle(bool IsEnable = true)
	{
	}

	public void SnapObjectToScreenEdge(RectTransform objectRect, bool alignLeft, CharacterName characterName)
	{
	}
}
