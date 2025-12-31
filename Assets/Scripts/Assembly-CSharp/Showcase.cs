using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Showcase : MonoBehaviour
{
	public GameObject ToyScroll;

	public GameObject StickerScroll;

	public GameObject StampScroll;

	public GameObject ToybtnImg;

	public GameObject StickerbtnImg;

	public GameObject StampImg;

	private GameObject PaggingEnable;

	private GameObject PaggingDisable;

	public int maxAllowedSticker;

	private int pageCount;

	private List<float> valueList;

	private XElement[] stickerArray;

	private XElement[] ToyArray;

	private XElement[] StampArray;

	private void Start()
	{
	}

	private void CheckToyOrSticker()
	{
	}

	public void OnBackBtnPressed()
	{
	}

	public void OnBtnToy()
	{
	}

	public void OnBtnStamp()
	{
	}

	private void EnableToy()
	{
	}

	private void LoadToyData()
	{
	}

	public void OnBtnSticker()
	{
	}

	private void EnableSticker()
	{
	}

	private void EnableStamp()
	{
	}

	private void LoadStickerData()
	{
	}

	private void LoadStampData()
	{
	}

	public void OnValueChangedScrollbar(Scrollbar value)
	{
	}

	public void PointerEnter(Transform sticker)
	{
	}

	public void PointerExit(Transform sticker)
	{
	}
}
