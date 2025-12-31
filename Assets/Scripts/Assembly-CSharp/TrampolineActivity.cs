using Spine;
using Spine.Unity;
using UnityEngine;

[RequireComponent(typeof(SkeletonGraphic))]
public class TrampolineActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	[SerializeField]
	private float _lucasActivityScale;

	private SkeletonGraphic TrampolineSpine;

	private int TrampolineCounter;

	private int Counter;

	private int thisActivitiesCanvasSortingOrder;

	bool IGardenActivities.IsactivityFree => false;

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

	public void TrampolineEventCallBack(TrackEntry trackEntry, Event eventdata)
	{
	}

	private void ReSetTrampolineActivity()
	{
	}

	private void SetTrampolineToIdle()
	{
	}
}
