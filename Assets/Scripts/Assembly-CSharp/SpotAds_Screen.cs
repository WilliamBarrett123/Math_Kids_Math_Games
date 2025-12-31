using UnityEngine;

public class SpotAds_Screen : MonoBehaviour
{
	public static SpotAds_Screen Instance;

	private GameObject CurrentActiveGame;

	[SerializeField]
	private GameObject selectedImage;

	[SerializeField]
	private GameObject txt_Title;

	[SerializeField]
	private GameObject btnDownload;

	[SerializeField]
	private GameObject btnGameObjectPanel;

	[SerializeField]
	private GameObject BigBaneerPanel;

	[SerializeField]
	private CanvasGroup CanvasBigBaneerPanel;

	[SerializeField]
	private string DownloadNowTxtID;

	[SerializeField]
	private string PlayNowTxtID;

	[SerializeField]
	private bool isParentSection;

	private void Start()
	{
	}

	public void SetBannerImages()
	{
	}

	private void OnEnable()
	{
	}

	private void BottomButtonActive(string gameName)
	{
	}

	public void onGameClick(GameObject thisGameObject)
	{
	}

	public void onDownloadOrPlayButtonClick(GameObject thisGameObject)
	{
	}

	private void OpenApplication()
	{
	}

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}
}
