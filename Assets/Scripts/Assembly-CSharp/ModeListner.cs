using System.Xml.Linq;
using UnityEngine;

public class ModeListner : MonoBehaviour, IModebuttonListner<Transform, ModeName>
{
	public ModeName modeName;

	public string PrefName;

	public VisibleModeNew visibleModeNew;

	public GameObject ToggleButton;

	private bool Togglevalue;

	private XElement visibleMode;

	private bool IsAdd;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void OnModeButtonClick(Transform data, ModeName mode)
	{
	}

	private void SetPrefValue()
	{
	}

	private void SetValueBack(bool _isadd)
	{
	}
}
