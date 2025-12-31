using System.Collections.Generic;
using UnityEngine;

public class GameAssetManager : MonoBehaviour
{
	[HideInInspector]
	public List<string> installtimeAssetBundleNameList;

	[HideInInspector]
	public List<string> fastfollowAssetBundleNameList;

	[HideInInspector]
	public List<string> ondemandAssetBundleNameList;

	private Dictionary<string, AssetBundle> assetBundles;

	public Dictionary<string, AssetBundle> AssetBundles
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public List<string> GetAssetBundleNameList()
	{
		return null;
	}

	public AssetBundle GetAssetBundleForName(string assetBundleName)
	{
		return null;
	}

	public void AddAssetBundle(string assetBundleName, AssetBundle assetBundle)
	{
	}
}
