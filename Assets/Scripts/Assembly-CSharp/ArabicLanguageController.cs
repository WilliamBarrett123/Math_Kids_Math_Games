using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ArabicLanguageController : Singleton<ArabicLanguageController>
{
	public bool IsArabicLanguage;

	public static event Action LanguageChange
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

	public static event Action EnglishToArabic
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

	private void OnDisable()
	{
	}

	private void OnLocaleChanged(Locale locale)
	{
	}

	public string NumberConvertToArabic(string number, string locale, Transform obj = null, int IncreaseFontSize = 0, bool IsGameplay = true, bool isConvert = false)
	{
		return null;
	}

	public string ConvertArabicNumberToEnglishNumber(string text, Transform TextObj = null)
	{
		return null;
	}

	public string ConvertPersianNumberToEnglishNumber(string text)
	{
		return null;
	}

	public void SetTablenamelocalization(Text setText, string locale, bool ignoreislocalize = false)
	{
	}

	public string ValueChangeLocaleWise(string number, string LAnguagelocale)
	{
		return null;
	}

	public void ChangeFontSize(Transform textchange, int incresevalue)
	{
	}

	public bool IsNumberLocalized()
	{
		return false;
	}

	public string ChangeInEnglish(Transform Obj)
	{
		return null;
	}

	private void OnGUI()
	{
	}
}
