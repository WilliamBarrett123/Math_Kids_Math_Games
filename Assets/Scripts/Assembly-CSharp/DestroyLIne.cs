using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DestroyLIne : Singleton<DestroyLIne>
{
	[CompilerGenerated]
	private sealed class _003CDrawNumber_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DestroyLIne _003C_003E4__this;

		private int _003Ci_003E5__2;

		private int _003Cj_003E5__3;

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
		public _003CDrawNumber_003Ed__22(int _003C_003E1__state)
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

	public GameObject FirstAnim;

	public GameObject SecondAnim;

	public GameObject ThirdAnim;

	public GameObject FourthAnim;

	private GameObject LastSlectedObject;

	public GameObject Chock;

	public GameObject Duster;

	public bool IsDusterAnim;

	private List<GameObject> ListOfBoardText;

	private List<List<GameObject>> DotList;

	private List<GameObject> NewList;

	private WaitForSeconds delay;

	private int RandomNumber;

	private GameObject NameofLoadObject;

	private GameObject ChockObject;

	private Image DotListImage;

	private WaitForSeconds Delay1;

	private WaitForSeconds Delay2;

	private WaitForSeconds Delay3;

	private int DotListCount;

	private int DotListChildCount;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CDrawNumber_003Ed__22))]
	public IEnumerator DrawNumber()
	{
		return null;
	}

	private void AddNameofLoadObjectInList(GameObject NameofLoadObject)
	{
	}

	public void CallingAgain()
	{
	}

	public void OnRecursionDrawing()
	{
	}

	public void OnAnimationCompleteStop()
	{
	}

	private void OnDisable()
	{
	}
}
