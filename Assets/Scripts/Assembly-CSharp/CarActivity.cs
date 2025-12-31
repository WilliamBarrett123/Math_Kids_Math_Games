using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Spine;
using UnityEngine;

public class CarActivity : GardenStateInfo, IGardenActivities
{
	[CompilerGenerated]
	private sealed class _003CDestroyCar_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject Tempcar;

		public CarActivity _003C_003E4__this;

		private Transform _003CCarparticle_003E5__2;

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
		public _003CDestroyCar_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CMoveContent_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CarActivity _003C_003E4__this;

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
		public _003CMoveContent_003Ed__27(int _003C_003E1__state)
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
	private GameObject _Car;

	private float Diff;

	private float EndVlaue;

	public AnimationCurve curve;

	private float duration;

	private float timeElapsed;

	private Tweener Tire1Tweener;

	private Tweener Tire2Tweener;

	private float _carAnimDuaration;

	private bool iScarActivityEnd;

	private GameObject TempCar;

	private int thisActivitiesCanvasSortingOrder;

	private int tempcarlayer;

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

	private void LucasEventCallBack(TrackEntry trackEntry, Event e)
	{
	}

	private void LucasAnimation_Interrupt_Callback(TrackEntry trackEntry)
	{
	}

	public void CarActivityFun()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveContent_003Ed__27))]
	private IEnumerator MoveContent()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDestroyCar_003Ed__28))]
	private IEnumerator DestroyCar(GameObject Tempcar)
	{
		return null;
	}

	private void ResetCarActivity()
	{
	}
}
