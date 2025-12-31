using UnityEngine;
using UnityEngine.UI;

public class GamePlayCloseHandling : Singleton<GamePlayCloseHandling>
{
	private GameObject NextButton;

	private GameObject BlackBackground;

	private GameObject HandObj;

	private GameObject SelectedButton;

	private GameObject SelectedPuzzlePiece;

	private bool isClose;

	private Slider slidermenu;

	public static bool isDragObject;

	private bool isCallFromFunction;

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnCloseSlider(Slider slider)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestory()
	{
	}

	public void OnPointerExit(Slider slider)
	{
	}

	public void OnDragBegin(Slider slider)
	{
	}

	public void OnPointerEnter(Slider slider)
	{
	}

	public void CloseButtonDisplay()
	{
	}

	public void OnDRagingEnd(Slider slider)
	{
	}

	public void nextScreenShow()
	{
	}

	public void OnNext()
	{
	}

	public void GamePlayCloseFunCalling(string ModeName)
	{
	}

	private void OnApplicationPause()
	{
	}
}
