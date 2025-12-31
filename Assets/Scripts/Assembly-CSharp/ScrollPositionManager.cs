using System.Collections.Generic;
using UnityEngine;

public class ScrollPositionManager : MonoBehaviour
{
	[SerializeField]
	private RectTransform _mainContainer;

	[SerializeField]
	private RectTransform section_1;

	[SerializeField]
	private RectTransform section_2;

	[SerializeField]
	private RectTransform section_3;

	[SerializeField]
	private RectTransform section_4;

	[SerializeField]
	private RectTransform scrollArea_Container;

	[SerializeField]
	private RectTransform section_1_button;

	[SerializeField]
	private RectTransform section_2_button;

	[SerializeField]
	private RectTransform section_3_button;

	[SerializeField]
	private RectTransform section_4_button;

	private float scrollArea_Height;

	private float _mainContainer_height;

	private float section_1_Pos;

	private float section_2_Pos;

	private float section_3_Pos;

	private float section_4_Pos;

	public List<float> _precValues_Sections;

	private void OnEnable()
	{
	}

	private void GetAllPositions()
	{
	}
}
