using System;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

public class BallonActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	[SerializeField]
	private float _lucasActivityScale;

	private int thisActivitiesCanvasSortingOrder;

	public static ICharacter ballonPerformingCharacter;

	public bool IsactivityFree => false;

	public static event Action AllBalloonPop
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void EnterState(ICharacter character)
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

	private void LucasEvent_Complete_CallBack(TrackEntry trackEntry)
	{
	}

	private void LucasEventCallBack(TrackEntry trackEntry, Event eventdata)
	{
	}

	private void LucasAnimation_Interrupt_Callback(TrackEntry trackEntry)
	{
	}

	public static ICharacter GetBallonActivityCharacter()
	{
		return null;
	}
}
