using Spine;
using UnityEngine;

public class DragActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	private string _currentrayCastObjName;

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

	public void SetCurrentRaycastObjectName(string name)
	{
	}

	public void SetRealeaseAnimation()
	{
	}
}
