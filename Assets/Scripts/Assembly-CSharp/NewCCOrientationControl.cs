using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewCCOrientationControl : MonoBehaviour
{
	public static NewCCOrientationControl Instance;

	public static float CheckDelay;

	private static ScreenOrientation orientation;

	public bool iSLandScapeLeft;

	public bool iSLandScapeRight;

	public static event Action OnOrientationChange
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnOrientationChanged()
	{
	}

	private void Start()
	{
	}

	public void CheckForOrientationChange()
	{
	}
}
