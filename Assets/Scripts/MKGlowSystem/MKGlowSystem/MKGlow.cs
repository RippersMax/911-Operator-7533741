using UnityEngine;

namespace MKGlowSystem
{
	public class MKGlow : MonoBehaviour
	{
		[SerializeField]
		private Shader m_NoGarbageBlurShader;
		[SerializeField]
		private Shader m_BlurShader;
		[SerializeField]
		private Shader m_CompositeShader;
		[SerializeField]
		private Shader m_GlowRenderShader;
		[SerializeField]
		private Shader m_FSDSShader;
		[SerializeField]
		private GlowBlurCurve m_GlowCurve;
		[SerializeField]
		private LayerMask m_GlowRenderLayer;
		[SerializeField]
		private MKGlowMode m_GlowResolution;
		[SerializeField]
		private bool m_ShowCutoutGlow;
		[SerializeField]
		private bool m_ShowTransparentGlow;
		[SerializeField]
		private MKGlowType m_GlowType;
		[SerializeField]
		private MKGlowQuality m_GlowQuality;
		[SerializeField]
		private Color m_FullScreenGlowTint;
		[SerializeField]
		private float m_BlurSpread;
		[SerializeField]
		private int m_BlurIterations;
		[SerializeField]
		private float m_GlowIntensity;
		[SerializeField]
		private float m_BlurOffset;
		[SerializeField]
		private int m_Samples;
	}
}
