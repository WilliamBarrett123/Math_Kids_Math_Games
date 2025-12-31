using DG.Tweening;
using Spine;
using UnityEngine;

public class PianoActivity : GardenStateInfo, IGardenActivities
{
	public class MovementConfig
	{
		public int JumpCount { get; set; }

		public int KeyCountChange { get; set; }

		public float PositionChange { get; set; }

		public MovementConfig(int jumpCount, int keyCountChange, float positionChange)
		{
		}
	}

	private ICharacter _character;

	[SerializeField]
	private float _lucasActivityScale;

	private Transform PianoMusicpartilce;

	private bool BgPianoSound1;

	private RectTransform TempObjpos;

	private int jumpCount;

	private int KeyCount;

	private bool FirstJump;

	private float oldTime;

	private float DiffTime;

	private Tweener _pianoJumpTween;

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

	private void SetPianoEndAnimation()
	{
	}

	public void PianoActivityFun(GameObject _DropObject)
	{
	}

	private void CheckforTime()
	{
	}

	private void HandlePianoMovement(string position, int jumpCount)
	{
	}

	private void ResetPianoActivity()
	{
	}
}
