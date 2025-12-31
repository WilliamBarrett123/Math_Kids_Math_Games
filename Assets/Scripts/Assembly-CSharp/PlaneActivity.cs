using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

public class PlaneActivity : GardenStateInfo, IGardenActivities
{
	[CompilerGenerated]
	private sealed class _003CSetJumpFromPlaneAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlaneActivity _003C_003E4__this;

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
		public _003CSetJumpFromPlaneAnimation_003Ed__22(int _003C_003E1__state)
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
	private float _lucasActivityScale;

	[SerializeField]
	private GameObject _springPlane;

	[SerializeField]
	private GameObject _dummyPlane;

	private string PlaneAnim_Name1;

	private string PlaneAnim_Name2;

	private float _planeDownMovingYValue;

	private Vector2 _planePosition;

	private float _planeScale;

	private Vector2 _beforeJumpFromplane;

	private int thisActivitiesCanvasSortingOrder;

	bool IGardenActivities.IsactivityFree => false;

	private void Awake()
	{
	}

	public void EnterState(ICharacter character)
	{
	}

	public void ExitState()
	{
	}

	private void SetCharacterPerformingActivityStatus(bool isCharacterPerformingActivity = true)
	{
	}

	public Vector2 GetUIElementSize(RectTransform uiElement)
	{
		return default(Vector2);
	}

	private void LucasEvent_Complete_CallBack(TrackEntry trackEntry)
	{
	}

	private void LucasEventCallBack(TrackEntry trackEntry, Event eventdata)
	{
	}

	private void LucasAnimation_Interrupt_Callback(TrackEntry trackEntry)
	{
	}

	private void ReSetPlaneActivity()
	{
	}

	[IteratorStateMachine(typeof(_003CSetJumpFromPlaneAnimation_003Ed__22))]
	private IEnumerator SetJumpFromPlaneAnimation()
	{
		return null;
	}
}
