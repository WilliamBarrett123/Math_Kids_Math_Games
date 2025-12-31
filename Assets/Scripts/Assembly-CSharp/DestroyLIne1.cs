using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DestroyLIne1 : Singleton<DestroyLIne>
{
	[CompilerGenerated]
	private sealed class _003CDrawNumber_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DestroyLIne1 _003C_003E4__this;

		private WaitForSeconds _003CPointOneDelay_003E5__2;

		private WaitForSeconds _003CPointZeroSevenDelay_003E5__3;

		private GameObject _003CNameofLoadObject_003E5__4;

		private GameObject _003CChockObject_003E5__5;

		private int _003Ccount_003E5__6;

		private IEnumerator _003C_003E7__wrap6;

		private IEnumerator _003C_003E7__wrap7;

		private IEnumerator _003C_003E7__wrap8;

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
		public _003CDrawNumber_003Ed__17(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		private void _003C_003Em__Finally3()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public AudioClip chock1;

	public AudioClip chockTap;

	public GameObject FirstAnim;

	public GameObject SecondAnim;

	public GameObject ThirdAnim;

	public GameObject FourthAnim;

	public GameObject FifthAnim;

	private GameObject LastSlectedObject;

	public GameObject Chock;

	public AudioClip ChockSound1;

	public AudioClip ChockSound2;

	public AudioClip ChockSound3;

	public GameObject Duster;

	public bool IsDusterAnim;

	private List<GameObject> ListOfBoardText;

	private List<List<GameObject>> DotList;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CDrawNumber_003Ed__17))]
	private IEnumerator DrawNumber()
	{
		return null;
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
