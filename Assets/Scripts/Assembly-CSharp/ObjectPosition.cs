using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
	public Vector3 BelowExtraTallFold6;

	public Vector3 ExtraTallFold6;

	public Vector3 ExtraTall;

	public Vector3 Tall;

	public Vector3 NormalTall;

	public Vector3 Normal;

	public Vector3 Wide;

	public Vector3 ExtraWide;

	[SerializeField]
	private bool updateOnlyX;

	[SerializeField]
	private bool updateOnlyY;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void UpdateResolution()
	{
	}
}
