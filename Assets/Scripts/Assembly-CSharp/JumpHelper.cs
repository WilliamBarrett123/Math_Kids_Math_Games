using System.Collections.Generic;
using UnityEngine;

public class JumpHelper : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem particleJump;

	public Vector3 posToReach;

	[SerializeField]
	private bool allowJump;

	private snowBallAnimState currentState;

	private bool callCompleteAnimation;

	private int currentPosId;

	private int posIdToReach;

	private List<Vector3> allPositions;

	private float lerpvalue;

	private float learpvalue_exit;

	private float lerpvalue_Entry;

	public void JumpBallParticle()
	{
	}

	public void SetReachPosforScreenEntry(List<Vector3> pos, snowBallAnimState state, float delay)
	{
	}

	public void SetPosForPlaceChange(Vector3 pos, snowBallAnimState state, float delay)
	{
	}

	public void SetJumpAnimation()
	{
	}

	public void Resetvariables()
	{
	}

	public void OnJumpStart()
	{
	}

	private void singleBallExitAnimation()
	{
	}

	private void PlaceChangeAnimation()
	{
	}

	private void SingleBallEntryAnimation()
	{
	}

	private void EntryAnimation()
	{
	}
}
