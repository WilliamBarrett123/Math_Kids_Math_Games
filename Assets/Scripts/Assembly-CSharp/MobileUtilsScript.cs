using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MobileUtilsScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFPS_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MobileUtilsScript _003C_003E4__this;

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
		public _003CFPS_003Ed__9(int _003C_003E1__state)
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

	private float frequency;

	[SerializeField]
	private Text fpxtext;

	private WaitForSeconds wfs;

	private int mFPS;

	private int lastFrameCount;

	private float lastTime;

	private float timeSpan;

	private int frameCount;

	private int lastFPS;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CFPS_003Ed__9))]
	private IEnumerator FPS()
	{
		return null;
	}

	public void OnChangeFPS()
	{
	}
}
