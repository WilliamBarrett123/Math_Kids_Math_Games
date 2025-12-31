using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWriteOnOutputImage_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraScript _003C_003E4__this;

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
		public _003CWriteOnOutputImage_003Ed__18(int _003C_003E1__state)
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

	private Action<string> OnScreenCapturedCallBack;

	public static CameraScript Instance;

	[HideInInspector]
	public GameObject CapturedScreen_Obj;

	private bool grab;

	private int x;

	private int y;

	private int width;

	private int height;

	private Texture2D dummyTexture;

	private GameObject obj;

	[SerializeField]
	private Transform CanvasObj;

	private RenderTexture _rendertex;

	[HideInInspector]
	public string CapturedImage_path;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void loadScreenForCapture(Action<string> onCaptureCallBack_)
	{
	}

	private void OnDisable()
	{
	}

	private void OnPostRender()
	{
	}

	[IteratorStateMachine(typeof(_003CWriteOnOutputImage_003Ed__18))]
	private IEnumerator WriteOnOutputImage()
	{
		return null;
	}

	private void DeactiveCamera()
	{
	}

	public void Delete_capturedScreen()
	{
	}
}
