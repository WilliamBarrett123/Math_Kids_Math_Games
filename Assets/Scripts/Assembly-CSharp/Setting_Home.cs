using UnityEngine;
using UnityEngine.UI;

public class Setting_Home : MonoBehaviour
{
	public static Setting_Home Instance;

	[SerializeField]
	private Sprite pagingEnable;

	[SerializeField]
	private Sprite pagingDisable;

	[SerializeField]
	private Image page_1;

	[SerializeField]
	private Image page_2;

	[SerializeField]
	private Image page_3;

	private int instCurrentPage;

	private float instNextAnimationTime;

	private string url;

	[SerializeField]
	private AudioSource thisAudioSource;

	[SerializeField]
	private GameObject soundPlayGameobject;

	[SerializeField]
	private GameObject instagramContent;

	[SerializeField]
	private GameObject instagramContentShop;

	[SerializeField]
	private GameObject goSpeechAudio;

	[SerializeField]
	private GameObject goSpeechText;

	[SerializeField]
	private GameObject btnRateUs;

	[SerializeField]
	private GameObject btnRateUs_2;

	[SerializeField]
	private GameObject btnOurstory;

	[SerializeField]
	private GameObject btnOurstory_2;

	[SerializeField]
	private GameObject btnPrintable_2;

	[SerializeField]
	private GameObject SocialPanel;

	[SerializeField]
	private GameObject SocialPanel_2;

	[SerializeField]
	private GameObject translationFeedback;

	[SerializeField]
	private Selectable tabHomebutton;

	[SerializeField]
	private Selectable sound_0;

	private Slider ProgressBarParent;

	private Text txtRemainingTime;

	private Text txtCurrentTime;

	private int CurrentPlayClip;

	private float playedTime;

	private float remainingplayedTime;

	private Transform DownloadProgress;

	private Text txtDownloadProgress;

	[SerializeField]
	private Text txt_msg;

	[SerializeField]
	private Text txt_dave;

	[SerializeField]
	private Text txt_founder;

	[SerializeField]
	private Text txt_dearparents;

	[SerializeField]
	private GameObject img_bottom;

	private int SessionCount;

	private Transform currentPlayedTransform;

	public ScrollRect scroll;

	private float lastposition;

	private float delayforAnimation;

	private bool isArabicValSeted;

	private bool isDownloadingBundle;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnLocaleChanged(Locale locale)
	{
	}

	private void UpdateTextDave()
	{
	}

	public void UpdateRightSizeButtonsVisibility()
	{
	}

	private void OnDownloadSpeechAssetBundle(string bundlename)
	{
	}

	private void OnDisable()
	{
	}

	public void onSpeechNormalPlayButtonClicked(Transform thisTransform)
	{
	}

	public void StopSoundifPlaying()
	{
	}

	private void ChangeUIWhenChangeSound(int index, bool isOpen, bool isCanStartPlay = true)
	{
	}

	private void CurrentSpeechPlay()
	{
	}

	public void onSocialPlatfomFollowButtonClicked(Transform thisTransform)
	{
	}

	private void onShare()
	{
	}

	private void openURL()
	{
	}

	public void onRateUsButtonClicked(Transform thisTransform)
	{
	}

	public void onOurStoreVideoButtonClicked(Transform thisTransform)
	{
	}

	private void OurStoreCalled()
	{
	}

	public void onPrintAbleButtonClicked(Transform thisTransform)
	{
	}

	public void onGiphyButtonClicked(Transform thisTransform)
	{
	}

	public void onYoutubeVideoButtonClicked(Transform thisTransform)
	{
	}

	private void InstagramAnimationMove()
	{
	}

	public void OnValueChanged_Scroll(Vector2 velocity)
	{
	}

	private void changebool()
	{
	}

	public void onValueChangesInScroll(Vector2 pos)
	{
	}

	private void DisplayDownloadingProgressText()
	{
	}

	public void onTranslationFeedback(GameObject thisGameObject)
	{
	}

	public void OnShopButtonClick(Transform thisGameObject)
	{
	}
}
