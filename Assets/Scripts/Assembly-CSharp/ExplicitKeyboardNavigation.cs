using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplicitKeyboardNavigation : MonoBehaviour
{
	private enum DIRECTION
	{
		left = 0,
		right = 1,
		up = 2,
		down = 3
	}

	[Serializable]
	public class Explicit_Selectable
	{
		public Selectable selectableObject;

		public GameObject HighLightParent;

		public bool IsDropDownChild;
	}

	public List<Explicit_Selectable> lstOfExplicitSelectables;

	public List<Explicit_Selectable> lstOfDefaultSelectables;

	public bool IsListLoaded;

	public bool SelfHighlight;

	[HideInInspector]
	public Selectable LastSelected;

	private const string _Dropdown = "Dropdown List";

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DeselectSelectable()
	{
	}

	private void OnDisable()
	{
	}

	private void InvokeMethod()
	{
	}

	private void HandleHotKeySelect(DIRECTION _keyPressed)
	{
	}

	private void checkForNextSelectable(DIRECTION _keyPressed, Selectable currentSelection)
	{
	}

	private void CheckForHighLightParent(Selectable NextToNextSelectable, List<Explicit_Selectable> lstOfExplicit, bool iscallFromDefault = false)
	{
	}

	private Selectable FindNextSelectable(Selectable currentObject, DIRECTION _keyPressed)
	{
		return null;
	}

	public void SelectFirstSelectableAfterDelay(float delay = 0.5f)
	{
	}

	public void SelectFirstSelectable()
	{
	}
}
