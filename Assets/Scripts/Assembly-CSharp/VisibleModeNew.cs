using UnityEngine;

public class VisibleModeNew : MonoBehaviour
{
	public VisibleModeEvent<Transform> visibleModeEvent;

	public ModesEvent<Transform> _modesEvent;

	[SerializeField]
	private Transform SpellingButton;

	private Transform ActiveButtonTransForm;

	public int TotalNoofAdditionModes;

	public int TotalNoofSubStractionfModes;

	public int TotalNooFunfModes;

	[SerializeField]
	private GameObject MiniMumModesText;

	[SerializeField]
	private GameObject _fishModeButton;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void OnButtonClick(Transform thistransform)
	{
	}

	public void OnAdditionModeButtonClick(Transform thistransform)
	{
	}

	public void OnSubStractionButtonClick(Transform thistransform)
	{
	}

	public void OnFunModeButtonClick(Transform thistransform)
	{
	}

	private void OnModeButtonClick(Transform thisTransform, ModeName modeName, int totalModes)
	{
	}

	private void DeActiveMinTextObject()
	{
	}

	private void OnDisable()
	{
	}

	public void OnCloseButtonPressed(GameObject thisGameObject)
	{
	}
}
