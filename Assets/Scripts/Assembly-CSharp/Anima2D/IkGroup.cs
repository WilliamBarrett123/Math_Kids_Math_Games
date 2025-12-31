using System.Collections.Generic;
using UnityEngine;

namespace Anima2D
{
	public class IkGroup : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		private List<Ik2D> m_IkComponents;

		public void UpdateGroup()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
