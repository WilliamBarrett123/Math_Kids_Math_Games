using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SlerpTest5 : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveToPosition_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlerpTest5 _003C_003E4__this;

		private float _003CtimeStamp_003E5__2;

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
		public _003CMoveToPosition_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CchangeBending_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlerpTest5 _003C_003E4__this;

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
		public _003CchangeBending_003Ed__13(int _003C_003E1__state)
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

	private float oldX;

	private float oldY;

	private Vector3 startPos;

	private Vector3 endPos;

	private bool isStartRotation;

	private float angle;

	private Vector3 startPosition;

	private Vector3 endPosition;

	private Vector3 bending;

	private float timeToTravel;

	public void startAnimation(Vector3 sPos, Vector3 ePos, int tag = 0)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveToPosition_003Ed__12))]
	private IEnumerator MoveToPosition(int tag = 0)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CchangeBending_003Ed__13))]
	private IEnumerator changeBending()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
