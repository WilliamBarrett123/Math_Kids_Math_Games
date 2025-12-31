using UnityEngine;

public class BillingModeAnimtionControl : MonoBehaviour
{
	[SerializeField]
	private GameObject _note;

	[SerializeField]
	private GameObject _noteParent;

	[SerializeField]
	private GameObject _coin;

	[SerializeField]
	private GameObject _coinParent;

	[SerializeField]
	private AudioClip _coinSound;

	[SerializeField]
	private AudioClip _noteSound;

	public void SetActiveNote()
	{
	}

	public void SetActiveCoin()
	{
	}

	public void SetNotesSound()
	{
	}

	public void SetCoisSound()
	{
	}

	private bool HasMinOneNote()
	{
		return false;
	}

	private bool HasMinOneCoin()
	{
		return false;
	}
}
