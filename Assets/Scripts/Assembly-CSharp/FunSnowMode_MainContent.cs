using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FunSnowMode_MainContent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTurnOffFLag_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float _time;

		public Transform _t;

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
		public _003CTurnOffFLag_003Ed__37(int _003C_003E1__state)
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

	public static FunSnowMode_MainContent instance;

	[SerializeField]
	private Transform movingBg;

	[SerializeField]
	private Transform lucasParent;

	[SerializeField]
	private Transform dummyObject;

	private List<Vector3> resolutionPath;

	[SerializeField]
	private Vector3[] vectorPath;

	[SerializeField]
	private AnswerPanelAnimation answerPanelAnimation;

	[SerializeField]
	private int winCount;

	[SerializeField]
	private int rightCount;

	private bool AllowLUcasRightANim;

	private float walkDuration;

	private float slideDownDuration;

	private Vector3 lucasPos;

	[SerializeField]
	private GameObject CollectableObj;

	[SerializeField]
	private Vector3[] slideDownPath;

	[SerializeField]
	private Vector3[] hillClimbPathHlper;

	[SerializeField]
	private LucasAnimation lucasAnimation;

	private LucasPosition lucasPosition;

	private LucasDireciton lucasDireciton;

	[SerializeField]
	private Transform flag1;

	[SerializeField]
	private Transform flag2;

	[SerializeField]
	private Transform flag3;

	[SerializeField]
	private Transform flag4;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Reset()
	{
	}

	private void TranstitionCamera(float duration)
	{
	}

	public void SnowBallClick(int x)
	{
	}

	public void RightMatch()
	{
	}

	public void WrongMatch()
	{
	}

	public void ForceFunMode()
	{
	}

	public void CombinationMatch()
	{
	}

	private void RightCombinationMoveLucas()
	{
	}

	private void EndAnim()
	{
	}

	private void PacticleSpaw()
	{
	}

	public void SetCollectible()
	{
	}

	public void ResetAllFlags()
	{
	}

	[IteratorStateMachine(typeof(_003CTurnOffFLag_003Ed__37))]
	private IEnumerator TurnOffFLag(Transform _t, float _time)
	{
		return null;
	}
}
