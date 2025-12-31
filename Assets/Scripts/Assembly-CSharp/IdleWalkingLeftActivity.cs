using Spine;
using UnityEngine;

public class IdleWalkingLeftActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	private float thresold;

	public bool IsactivityFree => false;

	public void EnterState(ICharacter character)
	{
	}

	public void ExitState()
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
}
