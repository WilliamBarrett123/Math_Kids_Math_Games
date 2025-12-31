using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NumberdigitLangChange : MonoBehaviour
{
	private bool isClickOnButton;

	public static event Action<bool> OnDigitLangChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void OnButtonClick()
	{
	}
}
