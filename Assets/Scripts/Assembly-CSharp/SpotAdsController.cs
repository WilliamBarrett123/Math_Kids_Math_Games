using System.Collections.Generic;

public class SpotAdsController : Singleton<SpotAdsController>
{
	public class SpotAdsClass
	{
		public string ApplicationName { get; set; }

		public string GooglePackageName { get; set; }

		public string IOSPackageName { get; set; }

		public string AmazonPackageName { get; set; }

		public string WindowsPackageName { get; set; }

		public string macPackageName { get; set; }

		public bool isApplicationInstall { get; set; }

		public SpotAdsClass(string _ApplicationName, string _GooglePackageName, string _iosPackagename, string _amazonPackageName, string _windowsPackageName, string _macPackageName)
		{
		}
	}

	private List<SpotAdsClass> lstSpotAdsDisplay;

	private void Start()
	{
	}

	public bool isApplicationInstall(string ApplicationName)
	{
		return false;
	}

	private void onPlayButton(string PackageName)
	{
	}

	public void OpenApplicationInDevice(string ApplicationName)
	{
	}

	private void OpenStore(int NavigateURLIndex)
	{
	}
}
