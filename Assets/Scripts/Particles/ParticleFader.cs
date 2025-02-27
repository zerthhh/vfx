using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Airship
{
	public class ParticleFader : MonoBehaviour
	{
		[SerializeField]
		private List<ParticleSystem> m_particleSystemsToFade;

		private List<Renderer> m_renderersToFade;

		[SerializeField]
		private List<Renderer> m_meshRenderersToFade;

		[SerializeField]
		private float m_fadeTimeSeconds;

		[SerializeField]
		private float m_startingAlpha;

		[SerializeField]
		private bool m_resetAlphaOnEnable;

		[SerializeField]
		private string m_colorReferenceStr;

		private float m_particleAlpha;

		private Coroutine m_fadeParticleCoroutine;

		private bool m_isVisible;

		public ParticleSystem[] particleSystems { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetParticleVisibility(bool isVisible)
		{
		}

		private IEnumerator FadeParticleRenderers(bool isVisible)
		{
			return null;
		}

		private void SetRendererAlpha(float alpha)
		{
		}
	}
}
