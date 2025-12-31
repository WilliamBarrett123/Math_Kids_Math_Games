using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Locale
{
	public enum LanguageType
	{
		RTL = 1,
		LTR = 0
	}

	public string languageName;

	public string languageTitle;

	public string languageLocale;

	public LanguageType languageType;

	public float languageScaleFactor;

	public Sprite languageFlag;

	public bool isAvailable;

	public int languageLineSpacing;

	public int langaugeSequence;

	public Font LanguageFont;

	public List<LangaugeRegion> regionData;

	public Locale(string _languageName, string _languageTitle, string _languageLocale, LanguageType _languageType, float _languageScaleFactor, Sprite _languageFlag, bool _isAvailable, Font _LanguageFont, List<LangaugeRegion> _regionData, int _langaugeSequence, int _languageLineSPacing = 100)
	{
	}
}
