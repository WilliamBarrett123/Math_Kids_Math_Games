using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasScaler))]
public class CanvasAutoScalar : MonoBehaviour
{
	public static CanvasAutoScalar Instance;

	public float screenDefaultAspect;

	public static Vector2 lastReferenceResolution;

	public float screenAspect;

	public static float currentCanvasScalerHeight;

	public bool Fold6Device;

	public CanvasScaler _canvasScaler;

	private bool StartUpdate;

	[SerializeField]
	private bool loadingScene;

	private float SizehandlerAspect;

	public float canvasHeight;

	private float oldAspect;

	private float aspectOnMinSize;

	private void Awake()
	{
	}

	public void reCalculateData()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateCanvasScale()
	{
	}

	public Vector2 GetLastReference()
	{
		return default(Vector2);
	}

	public void ResetToDefaultPosition()
	{
	}
}
