using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ParentSectionPopUpUserSelect : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateOnWrong_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParentSectionPopUpUserSelect _003C_003E4__this;

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
		public _003CAnimateOnWrong_003Ed__45(int _003C_003E1__state)
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

	public Text RandomPassword;

	public Text RandomPassword_English;

	private Transform underLineContent;

	private string[] numbers;

	[SerializeField]
	private Transform NumberPad_Panel;

	[SerializeField]
	private GameObject DefaulInput;

	[SerializeField]
	private GameObject NewInput;

	[SerializeField]
	private GameObject[] TextPassword;

	[SerializeField]
	private GameObject[] passwordText;

	[SerializeField]
	private Text MiniText;

	[SerializeField]
	private GameObject inputArea;

	private string combinedpassword;

	private string cmprDigit;

	private int passwdCounter;

	private GameObject backBtn;

	private Transform container;

	[SerializeField]
	private GameObject dad;

	[SerializeField]
	private GameObject mom;

	private string systemLanguage;

	public List<string> NumberAdded;

	public List<string> EnglishNumberAdded;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FatherMotherCharacetrSetting()
	{
	}

	private void FatherMotherPosUpdate(float yPos)
	{
	}

	private void StopMotherHiAnim()
	{
	}

	private void StopFatherHiAnim()
	{
	}

	private void CallRandomHiAnim()
	{
	}

	private void PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
	}

	private void checkforInputDisplay()
	{
	}

	private void SetNumber()
	{
	}

	private void SetPasswordOld()
	{
	}

	private void GenerateRandomPassword()
	{
	}

	private string numberPassword(int DigitNum)
	{
		return null;
	}

	private string numberPasswordSystemLanguage(int DigitNum)
	{
		return null;
	}

	private void SetEqutionForNew()
	{
	}

	private void OnUserInput_TextChanged(int a)
	{
	}

	public void OnBtnNumPadPress(string num)
	{
	}

	private string Getnumberstring(string numberid)
	{
		return null;
	}

	public void ConcatString(string StringToConcat)
	{
	}

	private void OnCheckPasswordMatch()
	{
	}

	public void OnbtnDeleteEnterDigit()
	{
	}

	public void OnCloseButtonPressed()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateOnWrong_003Ed__45))]
	private IEnumerator AnimateOnWrong()
	{
		return null;
	}
}
