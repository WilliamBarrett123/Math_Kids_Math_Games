using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class LucasTouchController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CPlayClip_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip CurrentClip;

		public float Delay;

		public LucasTouchController _003C_003E4__this;

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
		public _003CPlayClip_003Ed__22(int _003C_003E1__state)
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

	[SerializeField]
	private AudioClip Touch_Face_Left;

	[SerializeField]
	private AudioClip Touch_Face_Right;

	[SerializeField]
	private AudioClip Touch_Face_Mid;

	[SerializeField]
	private AudioClip Touch_Face_Fun;

	[SerializeField]
	private AudioClip Touch_Left_Hand;

	[SerializeField]
	private AudioClip Touch_Left_Leg;

	[SerializeField]
	private AudioClip Touch_left_Leg2;

	[SerializeField]
	private AudioClip Touch_Left_Leg_Jump;

	[SerializeField]
	private AudioClip Touch_Right_Leg;

	[SerializeField]
	private AudioClip Touch_Right_Leg2;

	[SerializeField]
	private AudioClip Touch_Right_Leg_Jump;

	[SerializeField]
	private AudioClip Touch_Tummy1;

	[SerializeField]
	private AudioClip Touch_Tummy2;

	[SerializeField]
	private AudioClip Touch_Tummy3;

	[SerializeField]
	private AudioClip Touch_Tummy4;

	[SerializeField]
	private AudioClip Saying_No;

	[SerializeField]
	private AudioClip Saying_No_2;

	private List<string> lstPlayedAnim;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private void CallAnimationClip(string clipName)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClip_003Ed__22))]
	private IEnumerator PlayClip(AudioClip CurrentClip, float Delay = 0f)
	{
		return null;
	}
}
