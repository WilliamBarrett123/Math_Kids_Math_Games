using UnityEngine;

public class GameAssetReference
{
	private string assetName;

	private string assetLocation;

	private AssetBundle assetBundle;

	private long assetSize;

	private long assetOffset;

	public string AssetName
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string AssetLocation
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public AssetBundle AssetBundle
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public long AssetSize
	{
		get
		{
			return 0L;
		}
		private set
		{
		}
	}

	public long AssetOffset
	{
		get
		{
			return 0L;
		}
		private set
		{
		}
	}

	public GameAssetReference(string aName, string aLocation, AssetBundle aBundle, long aSize, long aOffset)
	{
	}
}
