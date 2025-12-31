using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class FishController : MonoBehaviour
{
	public enum FishType
	{
		Normal = 0,
		Dark = 1,
		Electric = 2,
		Crab = 3,
		Puffer = 4,
		Whale = 5,
		Dolphin = 6
	}

	[CompilerGenerated]
	private sealed class _003CSetActiveJmpBubblePartilce_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public FishController _003C_003E4__this;

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
		public _003CSetActiveJmpBubblePartilce_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CStartMoving_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishController _003C_003E4__this;

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
		public _003CStartMoving_003Ed__25(int _003C_003E1__state)
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

	private float smoothTime;

	[SerializeField]
	private Vector3 mousePosition;

	[SerializeField]
	private Vector3 posLeft;

	[SerializeField]
	private Vector3 posRight;

	[SerializeField]
	private Vector3 posTop;

	[SerializeField]
	private Vector3 posBottom;

	[SerializeField]
	public GameObject AnsVal;

	[SerializeField]
	public GameObject Eye;

	[SerializeField]
	public GameObject Eye2;

	[SerializeField]
	public GameObject particle;

	public bool isCatched;

	public string txtVal;

	public FishType fishType;

	private float ActualRectSizeX;

	private float PreSentDolphinPosx;

	public GameObject DolphinTrail;

	public GameObject DolphinRoatet2;

	public GameObject JumpBubble;

	public GameObject DanceBubble;

	public GameObject SpalshBubble;

	private List<float> lstSmoothTimes;

	public Tweener moveTween;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CStartMoving_003Ed__25))]
	public IEnumerator StartMoving()
	{
		return null;
	}

	public void OnFishButtonClick(Transform thisTransform)
	{
	}

	public void OnCrabRopeCut()
	{
	}

	public void OnPufferFish()
	{
	}

	public void OnElectricFish()
	{
	}

	public void OnWhaleFish()
	{
	}

	public void SetMovingAnimation(float Delay = 0f, float Frames = 150f)
	{
	}

	[IteratorStateMachine(typeof(_003CSetActiveJmpBubblePartilce_003Ed__32))]
	public IEnumerator SetActiveJmpBubblePartilce(float Delay = 0f)
	{
		return null;
	}

	public void OnPointerDownCustom(BaseEventData eventData)
	{
	}
}
