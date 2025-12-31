using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class translationFeedback : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPostUserFeedback_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CPostUserFeedback_003Ed__10(int _003C_003E1__state)
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
	public string Currentfeedback;

	public InputField InputField;

	public GameObject thankYou;

	[SerializeField]
	private GameObject sendButton;

	private void OnEnable()
	{
	}

	public void onCloseBtn()
	{
	}

	public void OnStartInputField(GameObject btnAddObj)
	{
	}

	public void OnEnterFieldEnd()
	{
	}

	private void CloseInvoke()
	{
	}

	public void onSendTranslationFeedback()
	{
	}

	[IteratorStateMachine(typeof(_003CPostUserFeedback_003Ed__10))]
	private IEnumerator PostUserFeedback(string feedback, string language)
	{
		return null;
	}
}
