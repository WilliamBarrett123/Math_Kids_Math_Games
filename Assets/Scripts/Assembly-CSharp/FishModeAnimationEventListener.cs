using UnityEngine;

public class FishModeAnimationEventListener : StateMachineBehaviour
{
	public float Delay;

	public AnimationCurve Rotate2Curve;

	private bool ISDancepCompleted;

	private bool ISRotate1Completed;

	private bool ISRotate2Completed;

	public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
	{
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
	{
	}
}
