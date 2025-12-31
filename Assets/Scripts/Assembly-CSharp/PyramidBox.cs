using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PyramidBox
{
	public GameObject boxObject;

	public Text boxText;

	public Image boxImage;

	public Image highlightImage;

	public int correctValue;

	public bool isQuestionMark;

	public bool isFilled;

	public int rowIndex;
}
