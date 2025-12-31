using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DeviceTypeDetector : MonoBehaviour
{
	public static DeviceTypeDetector Instance;

	[SerializeField]
	private bool isMultiWindowsMode_Editor;

	private bool isInMultiWindow;

	public event Action<bool> OnMultiWindowStateChanged
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

	private void OnRectTransformDimensionsChange()
	{
	}

	private void DetectDeviceType()
	{
	}

	public void EnableAutoRotation()
	{
	}

	public void DisableAutoRotation()
	{
	}

	private bool IsInMultiWindowMode(AndroidJavaObject activity)
	{
		return false;
	}

	public bool IsInMultiWindow()
	{
		return false;
	}
}
