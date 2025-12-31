using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIntroController : MonoBehaviour
{
	[Serializable]
	public class CharacterIntroDetails
	{
		public int Character_Id;

		public string Character_Name;

		public string Character_Video_Name;

		public bool isShowMainScreen;

		public CharacterIntroDetails(int _id, string _characterName, string _characterVideoName)
		{
		}
	}

	public static CharacterIntroController Instance;

	private List<CharacterIntroDetails> lstCharacterIntroData;

	[HideInInspector]
	public bool isAnyOtherAnimationWorking;

	[HideInInspector]
	public bool isLionShowInSplashScreen;

	[HideInInspector]
	public bool isShowLionAnimationMainScreen;

	private int CurrentDisplayPlaceCount;

	private List<string> lstCharacterName;

	private List<string> lstDisplayCharacterName;

	private List<string> lstAnimationLocation;

	private List<string> lstDisplayAnimationLocation;

	private GameObject Current_Spine;

	private bool isEventRegister;

	private bool startMainScreenAnimation;

	private string firstShowCharName;

	private void Awake()
	{
	}

	private void setDataOfVideo()
	{
	}

	private void ResetShowAnimation()
	{
	}

	private void OnScreenStatusUpdatedEventFire(bool isStatus, string screenName)
	{
	}

	public void StartAnimationFromMainScreen()
	{
	}

	private void StartFirstAnimation()
	{
	}

	private void ResetRectTransform(GameObject thisObject)
	{
	}

	public void AgainCounterForAnimation()
	{
	}

	public void StopAnimationFromMainScreen()
	{
	}

	private List<E> ShuffleList<E>(List<E> inputList)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
