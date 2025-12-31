using Spine;
using UnityEngine;

public class RadioActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	[SerializeField]
	private float _lucasActivityScale;

	private GameObject Radio;

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

	private void LucasAnimation_Interrupt_Callback(TrackEntry trackEntry)
	{
	}

	private void ReSetRadioActivity()
	{
	}
}
