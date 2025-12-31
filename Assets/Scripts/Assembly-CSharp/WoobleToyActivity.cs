using DG.Tweening;
using Spine;
using UnityEngine;

public class WoobleToyActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	[SerializeField]
	private int _lucasSortingOrder;

	[SerializeField]
	private float _lucasActivityScale;

	[SerializeField]
	private GameObject _WoobleToypos;

	[SerializeField]
	private GameObject _WoobleToyShadow;

	private GameObject _woobleToy;

	private int IdleHashState;

	private int WoobleToyShadowPunchHashState;

	private int WoobleToyShadowKickHashState;

	private bool ispunch;

	private bool WoobleToyPunchAnimation;

	private DG.Tweening.Sequence _woobleToySequence;

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

	private void WoobleToyShadowMovement()
	{
	}

	private void ResetWoobleToyActivity()
	{
	}
}
