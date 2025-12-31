using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AboutUSResolutionDetector : MonoBehaviour
{
	public static AboutUSResolutionDetector Instance;

	private Vector2 currentResolution;

	private Vector2 detectedResoltion;

	[HideInInspector]
	public ScreenTypeAboutus screenType;

	[HideInInspector]
	public float AspectRatio;

	[HideInInspector]
	public bool GamePauseEnable;

	[SerializeField]
	private ContentSizeFitter MainContent;

	public static event Action<Vector2> OnAboutUsResolutionChangedEvent
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

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void CheckResolution()
	{
	}

	public void SetContent()
	{
	}

	public void SetContentoff()
	{
	}

	public void SetContenton()
	{
	}

	private void SetMatchWidthorHeightAboutus()
	{
	}

	private void SetMatchWidthorHeightGrownUp()
	{
	}

	private void CalculateOurStoryAspectRation()
	{
	}
}
