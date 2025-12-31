using Spine;
using UnityEngine;

public class BathTubeActivity : GardenStateInfo, IGardenActivities
{
	private ICharacter _character;

	[SerializeField]
	private int _lucasSortingOrder;

	[SerializeField]
	private float _lucasActivityScale;

	[SerializeField]
	private GameObject layer5Animator;

	[SerializeField]
	private GameObject layer6Aniamtor;

	[SerializeField]
	private GameObject Layer3Animator;

	[SerializeField]
	private GameObject BallContainerLeft;

	[SerializeField]
	private GameObject BallContainerLeft1;

	[SerializeField]
	private GameObject BallContainerRight;

	[SerializeField]
	private GameObject BallContainerRight1;

	private bool isFIRST;

	private int MovingballoonsHashState;

	public bool IsactivityFree => false;

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

	private void SetBallAnimattion(GameObject leftConatiner, GameObject rightContainer)
	{
	}
}
