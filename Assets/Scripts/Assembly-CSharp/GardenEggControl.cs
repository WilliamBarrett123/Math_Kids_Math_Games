using System.Collections.Generic;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider2D), typeof(AudioSource), typeof(GraphicRaycaster))]
public class GardenEggControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[SerializeField]
	private SkeletonGraphic _eggSpine;

	private int AnimCounter;

	[SerializeField]
	[Header("These below all sounds plays when Lucas Drop on the Activity")]
	private AudioClip Egg_N_I_am_so_happy_01;

	[SerializeField]
	private AudioClip Egg_N_I_am_so_happy_02;

	[SerializeField]
	private AudioClip Egg_N_I_am_so_happy_03;

	[SerializeField]
	private AudioClip Egg_N_I_am_so_happy_04;

	[SerializeField]
	private AudioClip Egg_N_I_am_so_happy_05;

	[SerializeField]
	private AudioClip Egg_N_I_am_so_happy_06;

	[SerializeField]
	private AudioClip Wave_Wave_and_say_hello;

	[SerializeField]
	private AudioClip Jump_HappySmiling_05_6;

	[SerializeField]
	[Header("These below all sounds plays when Ruby Drop on the Activity")]
	private AudioClip RD_I_am_so_happy_01;

	[SerializeField]
	private AudioClip RD_I_am_so_happy_02;

	[SerializeField]
	private AudioClip RD_I_am_so_happy_03;

	[SerializeField]
	private AudioClip RD_I_am_so_happy_04;

	[SerializeField]
	private AudioClip RD_I_am_so_happy_05;

	[SerializeField]
	private AudioClip RD_I_am_so_happy_06;

	[SerializeField]
	public AudioClip RD_Wave_Wave_and_say_hello;

	[SerializeField]
	public AudioClip RD_Hehe_Laugh4;

	[Header("These below all sounds plays when the touhed by player")]
	[SerializeField]
	[Space(20f)]
	private AudioClip Dance_2_Hand_1;

	[SerializeField]
	private AudioClip Dance_2_Hand_2;

	[SerializeField]
	private AudioClip Dizziling;

	[SerializeField]
	private AudioClip Funny_Face_With_Hand;

	[SerializeField]
	private AudioClip Funny_Face_With_Hand_R;

	[SerializeField]
	private AudioClip Hi_1_Hand;

	[SerializeField]
	private AudioClip Hi_2_Hand;

	[SerializeField]
	private AudioClip Jump_Happy;

	private int _currentTouchAnimIndex;

	private AudioSource _eggAudioSource;

	private Dictionary<string, AudioClip> AudioClipsData;

	private Dictionary<string, AudioClip> AudioClipsData_Ruby;

	private int _isTouChAnimCounter;

	private BoxCollider2D _eggBoxCollider;

	private GraphicRaycaster _eggRayCaster;

	private bool isEventAlreadyPlaying;

	private ICharacter _character;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void EggSpineEventCallbacks(TrackEntry trackEntry, Event eggevent)
	{
	}

	private void playClip(AudioClip clip)
	{
	}

	private void EggSpineCompleteCallbacks(TrackEntry trackEntry)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnEnterEggFunActivity(string lucasAnimName)
	{
	}

	private bool IsSpecialAnimation(string animName)
	{
		return false;
	}

	public void TriggerIntruption()
	{
	}

	private void ExitState()
	{
	}

	private void CheckEggVisibilityAndSetVolume()
	{
	}

	private bool IsUIElementVisible(RectTransform uiElement)
	{
		return false;
	}
}
