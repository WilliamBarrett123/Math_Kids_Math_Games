using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AudioControlNewCC : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayAudioClip_003Ed__129 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isLucasAudio;

		public bool ISloopAudio;

		public AudioClip audioClip;

		public float Delay;

		public AudioControlNewCC _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPlayAudioClip_003Ed__129(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static AudioControlNewCC Instance;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioSource lucasAudioSource;

	[SerializeField]
	private AudioSource rubyAudioSource;

	[SerializeField]
	private AudioSource BgAudioSource;

	private AudioClip lets_go_Starting;

	private AudioClip Lucas_Entry_In_Garden;

	private AudioClip RD_Lets_play_Ruby;

	private AudioClip horse_Voice;

	private AudioClip hurray_horse;

	private AudioClip horse_Loop;

	private AudioClip RD_hurray_horse;

	private AudioClip Wobble_toy_Lucas_Laugh;

	private AudioClip Wobble_toy_Toing;

	private AudioClip RD_Wobble_toy_RD_Laugh;

	private AudioClip Trampoline_Jumping_Happy1;

	private AudioClip Trampoline_Jumping_Happy2;

	private AudioClip Trampoline_Jumping_Happy3;

	private AudioClip RD_Trampoline_Jumping_Happy1;

	private AudioClip RD_Trampoline_Jumping_Happy2;

	private AudioClip RD_Trampoline_Jumping_Happy3;

	private AudioClip Trampoline_Jumping1;

	private AudioClip Trampoline_Jumping2;

	private AudioClip Ball_Bounce;

	private AudioClip Ball_Kick;

	private AudioClip Car_Start;

	private AudioClip Car_Engine_loop;

	private AudioClip Car_Horn_1;

	private AudioClip I_love_My_Car_Ring_Done;

	private AudioClip RD_Whoa_This_car_is_amazing;

	private AudioClip Lu_Kick_Left_kung_fu;

	private AudioClip Lu_punch_Left_kung_fu;

	private AudioClip Punch;

	private AudioClip Punch_Wobble_toy;

	private AudioClip RD_Kick_Left_kung_fu;

	private AudioClip RD_punch_Left_kung_fu;

	private AudioClip Radio_Dance;

	private AudioClip Car_Change;

	private AudioClip BushesShaking;

	private AudioClip TreeShaking;

	private AudioClip MushRoomShaking;

	private AudioClip Lucas_Garden_BG_MUSIC;

	private AudioClip Lucas_Dizzy_Effect;

	private AudioClip RD_Dizzy_Effect;

	private List<AudioClip> Balloonpop;

	private AudioClip BgPianoSound1;

	private AudioClip BgPianoSound2;

	private AudioClip Hummmm;

	private AudioClip Paper_plain_Release;

	private AudioClip Paper_Plane_woohhoooo;

	private AudioClip RD_Hummmm;

	private AudioClip RD_Paper_Plane_woohhoooo;

	private AudioClip Mouth_Swoosh;

	private AudioClip Lucas_Jump;

	private AudioClip RD_Jump;

	private AudioClip Lucas_sneezing;

	private AudioClip RD_sneezing;

	private AudioClip Hello4;

	private AudioClip Hi_i_am_Lucas;

	private AudioClip RD_Hello4;

	private AudioClip RD_Hi_i_am_Ruby;

	private AudioClip Lag_1;

	private AudioClip Lag_2;

	private AudioClip Lucas_running_break_skid_1;

	private AudioClip Lucas_Pick_up;

	private AudioClip Lu_Bath_Tube_1time;

	private AudioClip RD_Pick_up;

	private AudioClip RD_Bath_Tube_1time;

	private AudioClip Ball_Appear_1;

	private AudioClip Balloon_Appear_1;

	private AudioClip Hey_Ruby;

	private AudioClip Lets_have_some_fun;

	private AudioClip yes_Lucas_RUBY;

	private AudioClip Blink;

	private AudioClip Hehehehehe_Balloon_pop;

	private AudioClip Ohh2;

	private AudioClip Pin_power_touch_Object;

	private AudioClip Pin_Power_Apper;

	private AudioClip Yahhhh1;

	private AudioClip RD_Ohh2;

	private AudioClip RD_Yahhhh1;

	private AudioClip Lu_Slide_1;

	private AudioClip Lu_Slide_2;

	private AudioClip RD_Slide_1;

	private AudioClip RD_Slide_2;

	private AudioClip RD_Hehehehehe_Balloon_pop;

	private AudioClip Lu_Football_Kick_Laugh;

	private AudioClip Hehehehehe_Laugh3;

	private AudioClip Rd_Football_Kick_Laugh;

	private AudioClip RD_Hehehehehe_Laugh3;

	private AudioClip Lu_Ball_Jump;

	private AudioClip RD_Ball_Jump;

	private AudioClip scooterRide;

	private AudioClip RD_scooterRide;

	private List<AudioClip> PianoKeyBoardSounds;

	private List<AudioClip> BathuTubSounds;

	private List<AudioClip> RD_BathuTubSounds;

	private List<AudioClip> SkateBoardSounds;

	private List<AudioClip> RD_SkateBoardSounds;

	private List<AudioClip> LucaspickUpSounds;

	private List<AudioClip> RD_pickUpSounds;

	private List<AudioClip> AlreadyPlyedSounds;

	[SerializeField]
	private List<AudioClip> MusicToyClips;

	[SerializeField]
	private AudioClip Plane_Music;

	[SerializeField]
	private AudioClip wooohhhh;

	[SerializeField]
	private AudioClip Lu_Laugh_3;

	[SerializeField]
	private AudioClip Yahoo_2;

	[SerializeField]
	private AudioClip Play_Audio;

	[SerializeField]
	private AudioClip RD_Laugh_3;

	[SerializeField]
	private AudioClip RD_wooohhhh;

	[SerializeField]
	private AudioClip RD_Yahoo_2;

	[Header("Easter Sounds")]
	[Space(20f)]
	[SerializeField]
	private AudioClip egg_touch_magic_Dust_Garden;

	[Space(20f)]
	[Header("Easter Sounds")]
	[SerializeField]
	private AudioClip Garde_Egg_bunny_Touch;

	[Space(20f)]
	[SerializeField]
	[Header("Easter Sounds")]
	private AudioClip Pot_Rabbit_Tap;

	private Dictionary<CharacterName, List<AudioClip>> BathTub_AlreadyPlayedSounds;

	private Dictionary<CharacterName, int> BathTub_RandomPlayingNum;

	private AssetBundle modeBundle;

	private int RandompalyingNum;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private AudioClip LoadAudioFromAssetBundle(string _audioClip)
	{
		return null;
	}

	public void SetSpicificAudio(string Clipname, float Delay = 0f, CharacterName characterName = CharacterName.Lucas)
	{
	}

	public void SetRandomAudioFromList(string Clipname, float Delay = 0f, CharacterName characterName = CharacterName.Lucas)
	{
	}

	public void SetThemeBasedAudio(string Clipname, float Delay = 0f)
	{
	}

	public void ShuffleList()
	{
	}

	private void SetRandomSounds(List<AudioClip> audioClips, int Randint, bool isLucasAudio)
	{
	}

	private void SetRandomBathTubSound(List<AudioClip> audioClips, int Randint, CharacterName characterName)
	{
	}

	private void Shuffle<T>(List<T> list)
	{
	}

	private List<AudioClip> RemoveDuplicates(List<AudioClip> list)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayAudioClip_003Ed__129))]
	private IEnumerator PlayAudioClip(AudioClip audioClip, float Delay = 0f, bool ISloopAudio = false, bool isLucasAudio = true)
	{
		return null;
	}

	public void StopAudioloop()
	{
	}

	public void StopBgAudioloop()
	{
	}

	public void StartBackgroundAudioClip()
	{
	}

	public void StopContentBackgroundMusic()
	{
	}

	public void OnMusicToyButtonClick(int Index)
	{
	}

	private void OnDisable()
	{
	}
}
