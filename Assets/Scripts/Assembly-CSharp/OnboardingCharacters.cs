using Spine;
using Spine.Unity;
using UnityEngine;

public class OnboardingCharacters : MonoBehaviour
{
	[SerializeField]
	private SkeletonAnimation skeletonAnimation;

	[SerializeField]
	private bool isLucas;

	[SerializeField]
	private AudioClip laugh;

	[SerializeField]
	private AudioClip yeah;

	private int LucasCount;

	private int rubyCount;

	private void OnEnable()
	{
	}

	public void AnimationSequence()
	{
	}

	private void AnimationStartEventCallbacks(TrackEntry trackEntry)
	{
	}

	private void AnimationCompleteCallbacks(TrackEntry trackEntry)
	{
	}

	private void AnimationEventCallbacks(TrackEntry TrackEntry, Event e)
	{
	}

	private void OnDisable()
	{
	}
}
