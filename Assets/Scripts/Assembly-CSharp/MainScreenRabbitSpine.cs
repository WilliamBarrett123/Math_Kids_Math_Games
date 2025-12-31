using Spine;
using Spine.Unity;
using UnityEngine;

public class MainScreenRabbitSpine : MonoBehaviour
{
	public static MainScreenRabbitSpine Instance;

	private SkeletonAnimation RabbitSkeletonAnimation;

	private string currentCharName;

	private string currentAnimationPlaceName;

	private int currentAnimationCount;

	[SerializeField]
	private AudioClip RabbitIntro;

	[SerializeField]
	private AudioClip RabbitLaugh;

	private AudioSource thisAudioSource;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void RabbitAnimationsEventCallbacks(TrackEntry TrackEntry, Event e)
	{
	}

	private void RabbitAnimationsCompleteCallbacks(TrackEntry TrackEntry)
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
