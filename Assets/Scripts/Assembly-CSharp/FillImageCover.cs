using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(RectTransform))]
public class FillImageCover : MonoBehaviour
{
	private RectTransform rectTransform;

	private RectTransform canvasRect;

	private Image image;

	private void Awake()
	{
	}

	public void Refresh()
	{
	}

	private void Start()
	{
	}

	private void OnRectTransformDimensionsChange()
	{
	}

	public static void RefreshAllFillImageCovers()
	{
	}

	private void FitImageCover()
	{
	}
}
