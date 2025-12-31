using System.Collections.Generic;

public class OurMissionController : Singleton<OurMissionController>
{
	private List<int> _listOfAppLaunchCount;

	private int _listOfAppLaunchRepeateCount;

	private List<int> _listOfSettingCount;

	private int _listOfSettingRepeateCount;

	private int _settingCount;

	private int _appLaunchCount;

	private void Awake()
	{
	}

	public bool isShowOurMissionPopup(bool isAppLaunch = true)
	{
		return false;
	}

	private bool IsMultipalOf(int count, int multipalOf)
	{
		return false;
	}
}
