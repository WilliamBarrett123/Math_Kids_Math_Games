using Spine;
using Spine.Unity;
using UnityEngine;

public class MainScreenOtherCharacterIntro : MonoBehaviour
{
	public static MainScreenOtherCharacterIntro Instance;

	private SkeletonAnimation AllCharacterSkeletonAnimation;

	private string currentCharName;

	private string currentAnimationPlaceName;

	private int currentAnimationCount;

	[SerializeField]
	private AudioClip Cat_Sound;

	[SerializeField]
	private AudioClip Bear_Sound;

	[SerializeField]
	private AudioClip Dino_Sound;

	[SerializeField]
	private AudioClip Cat_laugh_Sound;

	[SerializeField]
	private AudioClip Bear_laugh_Sound;

	[SerializeField]
	private AudioClip Dino_laugh_Sound;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void AllCharacterAnimationsEventCallbacks(TrackEntry TrackEntry, Event e)
	{
	}

	private void AllCharacterAnimationsCompleteCallbacks(TrackEntry TrackEntry)
	{
	}

	public void startCharacterAnimation(string charName, string AnimationPlaceName)
	{
	}

	private void startCharacterAnimation()
	{
	}

	private void endCharacterAnimation()
	{
	}
}
