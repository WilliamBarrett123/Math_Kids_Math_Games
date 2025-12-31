using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LocaleManager : MonoBehaviour
{
	public static LocaleManager Instance;

	[HideInInspector]
	public List<Locale> locales;

	public bool CheckSystemLanguageOnFirstLauchOnly;

	public string TxtID;

	[HideInInspector]
	public XDocument xDocLocale;

	[HideInInspector]
	public XDocument xDocLocale_English;

	[HideInInspector]
	public Locale currentLocale;

	public static string DeviceSystemLanguage;

	public Dictionary<string, string> xDocLocaleDic;

	private string Prelocale;

	private string systemLocale;

	private XElement localeText_1;

	private XDocument xDocLocale_SystemLang;

	private string LastParseXml;

	public static event Action<Locale> OnLocaleChangedEvent
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

	private void SpawnLanguageButtonForDebugBuild()
	{
	}

	public void ChangeLocale(string languageCode)
	{
	}

	public Locale GetCurrentLocale()
	{
		return null;
	}

	private void CreateLocaleList()
	{
	}

	public string getSystemLanguageCode()
	{
		return null;
	}

	public Locale GetLocaleFromCode(string languageCode)
	{
		return null;
	}

	public Locale GetLocaleFromName(string languageName)
	{
		return null;
	}

	public void initLocale(Locale locale)
	{
	}

	public string GetTextFromID(string _txtID)
	{
		return null;
	}

	public void ChangeFontForText_1(Text txtComponent, bool isSystemFont = false, bool isnepalitohindi = false)
	{
	}

	public Font GetFontFromLocale(string locale)
	{
		return null;
	}

	public void ChangeFontForText(Text txtComponent, string LANCode = "", bool isnepalitohindi = false)
	{
	}

	public string GetTextFromIDByLocaleCode(string _txtID, string localeCode)
	{
		return null;
	}

	public string GetFormattedTextFromID(string _txtID, TextFormation formation)
	{
		return null;
	}

	public string GetIDFromText(string _text)
	{
		return null;
	}

	public string GetLocaleNameFromAssetBundle(string bundleName)
	{
		return null;
	}

	public string GetAssetBundleNameFromCountryCode(string countryCode)
	{
		return null;
	}

	public string GetLanguageName(string languageCode)
	{
		return null;
	}
}
