public class InternetConnectionController : Singleton<InternetConnectionController>
{
	private void Awake()
	{
	}

	public bool IsInternetAvailable()
	{
		return false;
	}
}
