using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class TexturePainter : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	[SerializeField]
	private int textureWidth;

	[SerializeField]
	private int textureHeight;

	[SerializeField]
	private int brushSize;

	[Range(0f, 1f)]
	[SerializeField]
	private float brushHardness;

	[SerializeField]
	private string savedTextureFilename;

	[SerializeField]
	private PaintColor currentColor;

	private Texture2D drawTexture;

	private RawImage rawImage;

	private RectTransform rectTransform;

	private Color32[] pixels;

	private Vector2 lastPaintPosition;

	private bool isDragging;

	private Color32 paintColor32;

	private List<Vector2Int> brushPattern;

	private Dictionary<Vector2Int, float> brushIntensities;

	[SerializeField]
	private GameObject DusterMoving;

	[SerializeField]
	private GameObject Duster;

	[SerializeField]
	private Vector3 DuterDefaultposition;

	[SerializeField]
	private Vector3 DusteroffSetPos;

	[SerializeField]
	private Animator DusterAnimtor;

	private int DusterHelpCounter;

	private bool Dusterhelp;

	private readonly Dictionary<PaintColor, Color> colorMap;

	[SerializeField]
	private Transform ActivePencil;

	private PaintColor OldColor;

	[SerializeField]
	private RectTransform parentRectTransform;

	[SerializeField]
	private RectTransform DusterrectTransform;

	private bool IsDusterMoving;

	private void Awake()
	{
	}

	public void UpdatePaintColor(PaintColor newColor)
	{
	}

	public void UpdateCustomColor(Color customColor)
	{
	}

	public PaintColor GetCurrentColorEnum()
	{
		return default(PaintColor);
	}

	public Color GetCurrentColor()
	{
		return default(Color);
	}

	public void CycleToNextColor(Transform thistransfrom)
	{
	}

	private PaintColor SelctedColor(string colorname)
	{
		return default(PaintColor);
	}

	private void SetColorAfterClear(Transform thistransfrom)
	{
	}

	private bool IsPointerWithinParentBounds(Vector2 pointerWorldPosition)
	{
		return false;
	}

	private void PreCalculateBrushPattern()
	{
	}

	private void InitializeTexture()
	{
	}

	public void SaveTexture()
	{
	}

	public bool LoadTexture()
	{
		return false;
	}

	public Texture2D GetTexture()
	{
		return null;
	}

	public void DeleteSavedTexture()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnDusterPointerDown(BaseEventData baseEventData)
	{
	}

	public void OnDusterDrag(BaseEventData baseEventData)
	{
	}

	public void OnDusterPointerUp(BaseEventData baseEventData)
	{
	}

	private void ResetDusterDefaultPoisition()
	{
	}

	private Vector2Int GetTexelPosition(Vector2 localPoint)
	{
		return default(Vector2Int);
	}

	private void DrawLine(Vector2Int start, Vector2Int end)
	{
	}

	private void PaintImmediate(Vector2Int position)
	{
	}

	public void ClearTexture()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
