using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreenNavigation : MonoBehaviour
{
	private enum Direction
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

	public static MainScreenNavigation Instance;

	public List<Explicit_Selectable> lstOfExplicitSelectables;

	public List<Explicit_Selectable> lstOfAllGameModesPart1;

	public List<Explicit_Selectable> lstOfAllGameModesPart2;

	private List<Explicit_Selectable> lstOfActiveGameModesPart1;

	private List<Explicit_Selectable> lstOfActiveGameModesPart2;

	public List<Explicit_Selectable> lstOfDefaultSelectables;

	public bool isListLoaded;

	[HideInInspector]
	public Selectable lastSelected;

	private const string _Dropdown = "Dropdown List";

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void DeselectSelectable()
	{
	}

	private void OnScreenStatusUpdatedEvent(bool IsTrue, string Screen)
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleHotKeySelect(Direction _keyPressed)
	{
	}

	private void InvokeMethod()
	{
	}

	public void AddDropDownChildIntoSelectable(List<Selectable> dropdownContent, RectTransform scrollContent, ScrollRect scrollBar)
	{
	}

	public void ClearDropDownChild()
	{
	}

	private void checkForNextSelectable(Direction _keyPressed, Selectable currentSelection)
	{
	}

	private void CheckForHighLightParent(Selectable NextToNextSelectable, List<Explicit_Selectable> lstOfExplicit, bool iscallFromDefault = false)
	{
	}

	private Selectable FindNextSelectable(Selectable currentObject, Direction _keyPressed)
	{
		return null;
	}

	public void SelectableAfterHelp()
	{
	}

	public void MainMenuSelectFirstSelectable()
	{
	}
}
