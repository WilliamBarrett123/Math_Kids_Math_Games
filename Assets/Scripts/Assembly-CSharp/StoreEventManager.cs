using UnityEngine;

public class StoreEventManager : MonoBehaviour
{
	public static StoreEventManager Instance;

	public string myEventName;

	private void Awake()
	{
	}

	private void onDeepLinkActivated(string url)
	{
	}
}
