using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ResolutionDetector : Singleton<ResolutionDetector>
{
	private Vector2 currentResolution;

	private Vector2 detectedResoltion;

	[HideInInspector]
	public float AspectRatio;

	[HideInInspector]
	public ScreenType screenType;

	[HideInInspector]
	public ScreenType ourStoryType;

	[HideInInspector]
	public bool GamePauseEnable;

	private GameObject GamePause;

	public RectTransform _NotchMain;

	public RectTransform _NotchCHild;

	public GameObject canvas;

	private float oldAspect;

	public float targetAspectRatioHeight;

	public float targetAspectRatioWidth;

	[SerializeField]
	private GameObject LetterBoxGameObject;

	[SerializeField]
	private Camera mainCamera;

	[Space(20f)]
	[Header("New Variables")]
	[SerializeField]
	private bool _isNotchDevice_Editor;

	public static event Action<Vector2> OnResolutionChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void CheckResolution()
	{
	}

	public void CheckResolutionManually()
	{
	}

	private void OnApplicationPause(bool isPaused)
	{
	}

	private void CalculateAspectRation()
	{
	}

	private void CalculateOurStoryAspectRation()
	{
	}

	public void CheckForPauseGame()
	{
	}

	public void ResumeGame()
	{
	}

	private void OnApplicationFocus(bool isFocused)
	{
	}

	private void OnRectTransformDimensionsChange()
	{
	}

	private void UpdateLetterboxing()
	{
	}

	public void GetNotchInfo()
	{
	}
}
