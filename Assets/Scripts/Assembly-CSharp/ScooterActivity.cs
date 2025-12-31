using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

public class ScooterActivity : GardenStateInfo, IGardenActivities
{
	[CompilerGenerated]
	private sealed class _003CDestroyScooter_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject TempScooter;

		public ScooterActivity _003C_003E4__this;

		private Transform _003CScooterparticle_003E5__2;

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
		public _003CDestroyScooter_003Ed__26(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CMoveContent_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScooterActivity _003C_003E4__this;

		private float _003CtimeElapsed_003E5__2;

		private float _003CtargetX_003E5__3;

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
		public _003CMoveContent_003Ed__22(int _003C_003E1__state)
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

	private ICharacter _character;

	[SerializeField]
	private int _lucasSortingOrder;

	[SerializeField]
	private float _lucasActivityScale;

	[SerializeField]
	private GameObject _scooter;

	public AnimationCurve curve;

	private string Scooter_Name_Idle;

	private string Scooter_Name_Idle_EB;

	private string Scooter_Name_Paddle;

	private float _scooterAnimationCounter;

	private float _scooterAnimationCounterForEB;

	private float _scooterAnimDuaration;

	private float durationScooter;

	private int thisActivitiesCanvasSortingOrder;

	private GameObject TempScooter;

	private Vector3 _scooterPosition;

	private float Diff;

	private float _travelDistance;

	bool IGardenActivities.IsactivityFree => false;

	private void Awake()
	{
	}

	public void EnterState(ICharacter character)
	{
	}

	public void ScooterActivityFun()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveContent_003Ed__22))]
	private IEnumerator MoveContent()
	{
		return null;
	}

	public void ExitState()
	{
	}

	public Vector2 GetUIElementSize(RectTransform uiElement)
	{
		return default(Vector2);
	}

	private void LucasEvent_Complete_CallBack(TrackEntry trackEntry)
	{
	}

	[IteratorStateMachine(typeof(_003CDestroyScooter_003Ed__26))]
	private IEnumerator DestroyScooter(GameObject TempScooter)
	{
		return null;
	}

	private void LucasEventCallBack(TrackEntry trackEntry, Event eventdata)
	{
	}

	private void LucasAnimation_Interrupt_Callback(TrackEntry trackEntry)
	{
	}

	private void ResetScooterActivity()
	{
	}
}
