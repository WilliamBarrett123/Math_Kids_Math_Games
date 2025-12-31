using UnityEngine;
using UnityEngine.UI;

public class LoadingCanvasAdjust : MonoBehaviour
{
	public static LoadingCanvasAdjust Instance;

	[SerializeField]
	private CanvasScaler _cs;

	[HideInInspector]
	public float scaleValue;

	[HideInInspector]
	public float AspectRatio;

	[HideInInspector]
	public bool allowScale;

	[HideInInspector]
	public bool allowLogoScale;

	private float default_Aspect;

	public float targetAspectRatioHeight;

	public float targetAspectRatioWidth;

	[SerializeField]
	private GameObject LetterBoxGameObject;

	[SerializeField]
	private GameObject splashImage;

	[SerializeField]
	private Camera mainCamera;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void AspectHandler()
	{
	}

	private void LucasRubyPosAdjust()
	{
	}

	private void OnApplicationFocus(bool pause)
	{
	}

	private void UpdateLetterboxing()
	{
	}
}
