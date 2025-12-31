using System.Collections.Generic;
using Spine;
using UnityEngine;

public class AnimalMaskActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	[SerializeField]
	private int _lucasSortingOrder;

	[SerializeField]
	private float _lucasActivityScale;

	[SerializeField]
	private GameObject _cow;

	[SerializeField]
	private GameObject _ducky;

	[SerializeField]
	private GameObject _pig;

	[SerializeField]
	private List<string> AnimalSelectablelst;

	bool IGardenActivities.IsactivityFree => false;

	private void Awake()
	{
	}

	public void EnterState(ICharacter character)
	{
	}

	private void LucasEvent_Complete_CallBack(TrackEntry trackEntry)
	{
	}

	private void LucasEventCallBack(TrackEntry trackEntry, Event eventdata)
	{
	}

	private void LucasAnimation_Interrupt_Callback(TrackEntry trackEntry)
	{
	}

	private void ResetHulaHoopActivity()
	{
	}

	public void ExitState()
	{
	}

	private void SetCharacterPerformingActivityStatus(bool isCharacterPerformingActivity = true)
	{
	}

	public Vector2 GetUIElementSize(RectTransform uiElement)
	{
		return default(Vector2);
	}
}
