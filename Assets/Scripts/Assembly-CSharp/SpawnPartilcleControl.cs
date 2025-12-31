using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnPartilcleControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public string _partilceSpawnName;

		internal bool _003CSpawningpartilcesFrompool_003Eb__0(GameObject X)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAutopopUpballoonWithDelay_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnPartilcleControl _003C_003E4__this;

		private int _003Cj_003E5__2;

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
		public _003CAutopopUpballoonWithDelay_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CCheckParent_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform Parent;

		public SpawnPartilcleControl _003C_003E4__this;

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
		public _003CCheckParent_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CPopBallons_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float Delay;

		public SpawnPartilcleControl _003C_003E4__this;

		public GameObject thisgameObject;

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
		public _003CPopBallons_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CSpawnBallonsAgain_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnPartilcleControl _003C_003E4__this;

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
		public _003CSpawnBallonsAgain_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CSpawningpartilcesFrompool_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _partilceSpawnName;

		public float Delay;

		public SpawnPartilcleControl _003C_003E4__this;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		public GameObject ParentgameObject;

		public Vector3 _Particleposition;

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
		public _003CSpawningpartilcesFrompool_003Ed__41(int _003C_003E1__state)
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

	public static SpawnPartilcleControl Instance;

	[SerializeField]
	private List<GameObject> _BalloonParticles;

	[SerializeField]
	private GameObject _FirstPopBallon;

	public List<GameObject> Ballons;

	public List<GameObject> DummyBallons;

	private List<GameObject> Ropes;

	public List<GameObject> SetRelaseimages;

	[SerializeField]
	private GameObject BalloonStand;

	[SerializeField]
	private GameObject BalloonStandParent;

	public float BallonpopIdleTime;

	public float LastballonPopTime;

	private bool isAlredySpawning;

	private bool ISAlredyPoping;

	private int Randint;

	private GameObject _ParticleDummy;

	private int Count;

	public int RopeCount;

	private bool balloonCompleteAnimation;

	[SerializeField]
	private float balloonSDelay;

	private List<Color32> DummyColorCode;

	private List<Color32> ColorCode;

	[SerializeField]
	private GameObject PianoParticle;

	private GameObject TempPainoPaticle;

	private List<Vector2> PianoParticlePosition;

	[SerializeField]
	private List<GameObject> pooledObjects;

	[SerializeField]
	private List<string> pooledObjectNames;

	private GameObject _SpawnedParticle;

	private int ScaleAnimationHashState;

	[SerializeField]
	private Vector3 LucasDizzzy;

	private GameObject RadioParticle;

	[SerializeField]
	private ParticleSystem _treeShakeParticleTheme;

	[SerializeField]
	private Animator _butterFlyAnimator;

	private readonly string _butterFlyToucjanimName;

	private readonly string _houseScaleAnimName;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void PopAllTheBallons()
	{
	}

	public void PopBallonsInBetween()
	{
	}

	[IteratorStateMachine(typeof(_003CAutopopUpballoonWithDelay_003Ed__18))]
	public IEnumerator AutopopUpballoonWithDelay()
	{
		return null;
	}

	public void FirstBallonpopupAnimation()
	{
	}

	public void OnBallonButtonClicked(GameObject thisgameObject)
	{
	}

	private void SetBallonsAndRaycasting()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnBallonsAgain_003Ed__22))]
	public IEnumerator SpawnBallonsAgain()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPopBallons_003Ed__25))]
	private IEnumerator PopBallons(GameObject thisgameObject, float Delay = 0f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckParent_003Ed__29))]
	private IEnumerator CheckParent(Transform Parent)
	{
		return null;
	}

	public void Pianopartilce(GameObject Spawn, int jumpCount, bool iSLeft = true)
	{
	}

	public void ReleasePianoParticle()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawningpartilcesFrompool_003Ed__41))]
	public IEnumerator SpawningpartilcesFrompool(GameObject ParentgameObject, string _partilceSpawnName, Vector3 _Particleposition, float Delay = 0f)
	{
		return null;
	}

	public void ReturnToPool(GameObject thisgameobject)
	{
	}

	public void OnFrontTreeAnimation(GameObject thisgameobject)
	{
	}

	public void BackTreeAnimation(GameObject thisgameobject)
	{
	}

	public void OnBushesScaleAnimation(GameObject thisgameobject)
	{
	}

	public void OnActivityStart(Status status, GameObject thisgameobject, bool IsFirstAnim = false)
	{
	}

	public void OnActivityEnd()
	{
	}

	public void OnMushRoomButtonClick(GameObject thisgameobject)
	{
	}

	public void OnleafButtonClick(GameObject thisgameobject)
	{
	}

	public void SetInActiveParticle(string particleName)
	{
	}

	public void OnThemsTreeAnimation(GameObject thisgameobject)
	{
	}

	public void OnFlowerPotClicked(GameObject thisgameobject)
	{
	}

	public void OnHouseShoesButtonClick(GameObject thisgameobject)
	{
	}
}
