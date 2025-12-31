using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class BalloonExplosionCC : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CDestroyobject_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

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
		public _003CDestroyobject_003Ed__23(int _003C_003E1__state)
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

	[HideInInspector]
	public string particleName;

	[HideInInspector]
	public int BalloonNumber;

	[HideInInspector]
	public int AnimationID;

	private bool _isDown;

	private bool isOnceBlast;

	[HideInInspector]
	public bool isVisible;

	[HideInInspector]
	public bool isHelpBalloon;

	private Vector2 _defaultVectorPostion;

	private GameObject blastParticle;

	[HideInInspector]
	public GameObject correctParticle;

	[HideInInspector]
	public GameObject wrongParticle;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void isBalloonResume()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void DistroyMe(bool isShowBlastAnim)
	{
	}

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}

	private void correntBlastParticleShow()
	{
	}

	private void hideCorrentBlastParticle()
	{
	}

	public void AnimStarted()
	{
	}

	public void DistroyCornerBalloon()
	{
	}

	[IteratorStateMachine(typeof(_003CDestroyobject_003Ed__23))]
	private IEnumerator Destroyobject(float Delay = 0f)
	{
		return null;
	}
}
