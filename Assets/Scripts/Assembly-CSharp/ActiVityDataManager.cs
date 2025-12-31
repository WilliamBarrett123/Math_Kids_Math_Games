using UnityEngine;

public class ActiVityDataManager : MonoBehaviour
{
	public static ActiVityDataManager Instance;

	[Header("Boolean Vlaues")]
	public bool iSdrag;

	public bool SwicthingAnimation;

	public bool iSDrop;

	public bool LucasAlreadyAnimating;

	public bool SetLucasIdle;

	[Header("ScrollHandler")]
	[SerializeField]
	private ScrollHandler scrollHandler;

	[Header("Float Vlaues")]
	public float lastActivityTime;

	public float WalkingStartTime;

	public float SpeedofLucas;

	private void Awake()
	{
	}

	public void EnableDisbaleScrollHandle(bool IsEnable = true)
	{
	}
}
