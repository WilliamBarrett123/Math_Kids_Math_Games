using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class starforgame : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPostUserFeedback_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string language;

		public string feedback;

		private UnityWebRequest _003Cwww_003E5__2;

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
		public _003CPostUserFeedback_003Ed__33(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[HideInInspector]
	public bool isOpenFromRateUsButton;

	[SerializeField]
	private GameObject MainContainer;

	[SerializeField]
	private GameObject ThankFor4Container;

	[SerializeField]
	private GameObject starContainer;

	[SerializeField]
	private GameObject ThankFor5Container;

	[SerializeField]
	private Text txt_5starLoveGame;

	[SerializeField]
	private AudioClip audio_ThumsUp;

	private int starCount;

	private bool isClosePressed;

	private int count;

	private float SpawnTime;

	[HideInInspector]
	public string Currentfeedback;

	public InputField InputField;

	private Transform Confetti;

	private void Start()
	{
	}

	private void SelectFirstSelectableAfterDelay()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void EnableAnimator()
	{
	}

	private void DisableAnimator()
	{
	}

	private void Update()
	{
	}

	private void eventGet(int starNum)
	{
	}

	private void changeContainer()
	{
	}

	private void PlayThankYouSound()
	{
	}

	private void DestroyConfetti()
	{
	}

	private void SpawnConfetti()
	{
	}

	private void OnCloseButton()
	{
	}

	private void CallAfterClose()
	{
	}

	public void Close_Button_Pressed()
	{
	}

	public void OnStartInputField(GameObject btnAddObj)
	{
	}

	public void OnEnterFieldEnd()
	{
	}

	public void OnSendBtnClick(Transform thisTransform)
	{
	}

	private void SendFeedback()
	{
	}

	[IteratorStateMachine(typeof(_003CPostUserFeedback_003Ed__33))]
	private IEnumerator PostUserFeedback(string feedback, string language)
	{
		return null;
	}
}
