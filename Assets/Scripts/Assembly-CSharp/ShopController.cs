using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
	public static ShopController Instance;

	private List<shopData> lstShopData;

	public int CurrentAppLaunchForShop;

	public int ShopOpenCount;

	public bool IsAlreadyShow;

	public static bool IsValidCountryForShop;

	public static string getLanguageCodeValue;

	public string detectedCountryCode;

	private List<int> lstWayToSupport;

	public string ShopURLBook => null;

	public string ShopURL => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public int ShopCount()
	{
		return 0;
	}

	public string getUrlByID(int id)
	{
		return null;
	}

	public bool IsShowWayToSupportUS()
	{
		return false;
	}

	public static void OpenExternalURL(string url)
	{
	}
}
