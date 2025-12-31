using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TreeAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTreeHitCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreeAnimation _003C_003E4__this;

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
		public _003CTreeHitCoroutine_003Ed__11(int _003C_003E1__state)
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
	private Animator treeAniamtor;

	[SerializeField]
	private AudioClip Tree_Snow_Throw_Whoos;

	private AudioSource audioSource;

	private bool startHitAnim;

	private bool allowInput;

	[SerializeField]
	private Transform LucasTransform;

	[SerializeField]
	private Transform selfHitPos;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Init()
	{
	}

	private void DidItHitMe(Transform _transform)
	{
	}

	private void TreeEntry()
	{
	}

	public void TreeHit()
	{
	}

	[IteratorStateMachine(typeof(_003CTreeHitCoroutine_003Ed__11))]
	private IEnumerator TreeHitCoroutine()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void ReverseOnLucas()
	{
	}

	private void ENableINput()
	{
	}
}
