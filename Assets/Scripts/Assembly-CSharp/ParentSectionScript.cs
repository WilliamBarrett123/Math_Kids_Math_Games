using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ParentSectionScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateOnWrong_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParentSectionScript _003C_003E4__this;

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
		public _003CAnimateOnWrong_003Ed__56(int _003C_003E1__state)
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

	public static ParentSectionScript Instance;

	public Text RandomPassword;

	public Text RandomPassword_English;

	private Transform underLineContent;

	private string RandomTextReferenceToCompare;

	private string[] numbers;

	private int passwdCounter;

	public bool IsOpenFromMoreAppsHelp;

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

	private GameObject backBtn;

	private string[] numberTxt;

	[HideInInspector]
	public string txtCurrentOpenScreen;

	private Transform container;

	[SerializeField]
	private GameObject mom;

	[SerializeField]
	private GameObject dad;

	[SerializeField]
	private Transform reDirectTxt_IOS;

	[SerializeField]
	private Transform txt_Inst;

	private bool SetCanvas;

	private int GrownUpNumType;

	private string systemLanguage;

	public List<string> NumberAdded;

	public List<string> EnglishNumberAdded;

	private bool isBackFromWrong;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void setTextForIOS()
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

	private void SetPasswordOld()
	{
	}

	private void GenerateRandomPassword()
	{
	}

	private void SetNumber()
	{
	}

	private void SetEqutionForNew()
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

	private void OnDisable()
	{
	}

	private void ResolutionDetector_OnResolutionChangedEvent(Vector2 obj)
	{
	}

	private void OnCheckPasswordMatch()
	{
	}

	public void OnbtnDeleteEnterDigit(GameObject thisGameobject = null)
	{
	}

	public void OnCloseButtonPressed()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateOnWrong_003Ed__56))]
	private IEnumerator AnimateOnWrong()
	{
		return null;
	}
}
