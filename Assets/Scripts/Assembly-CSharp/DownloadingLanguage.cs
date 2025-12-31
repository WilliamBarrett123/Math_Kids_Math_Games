using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DownloadingLanguage : Singleton<DownloadingLanguage>
{
	public Text downloadingProgress;

	public Text downloadingContent;

	public GameObject closeButton;

	private string SelectedLanguage;

	private bool IsDownloadingStart;

	private bool isShowError;

	private Font requiredFont;

	public static event Action OnCloseBtnEnglishSet
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

	private void OnEnable()
	{
	}

	private void ShowDownloadProgress(float Progress)
	{
	}

	public void AutoCloseScreen()
	{
	}

	public void WaitLanguagePackDownloadScreen()
	{
	}

	private void ShowContinueInEnglish()
	{
	}

	private void CallIntialHelp()
	{
	}

	private void OnDownloadAssetBundleCalled(string bundle)
	{
	}

	private void OnDisable()
	{
	}

	private void EnableCloseButton()
	{
	}

	private void ChangeDownloadingText()
	{
	}

	public void OnCloseButtonPressed()
	{
	}

	public void OnCloseResponce()
	{
	}
}
