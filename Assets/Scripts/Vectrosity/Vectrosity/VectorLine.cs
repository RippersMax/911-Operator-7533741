using System;
using System.Collections.Generic;
using UnityEngine;

namespace Vectrosity
{
	[Serializable]
	public class VectorLine
	{
		public VectorLine(string name, List<Vector3> points, float width)
		{
		}

		[SerializeField]
		private Vector3[] m_lineVertices;
		[SerializeField]
		private Vector2[] m_lineUVs;
		[SerializeField]
		private Color32[] m_lineColors;
		[SerializeField]
		private List<int> m_lineTriangles;
		[SerializeField]
		private int m_vertexCount;
		[SerializeField]
		private GameObject m_go;
		[SerializeField]
		private RectTransform m_rectTransform;
		[SerializeField]
		private Color32 m_color;
		[SerializeField]
		private CanvasState m_canvasState;
		[SerializeField]
		private bool m_is2D;
		[SerializeField]
		private List<Vector2> m_points2;
		[SerializeField]
		private List<Vector3> m_points3;
		[SerializeField]
		private int m_pointsCount;
		[SerializeField]
		private Vector3[] m_screenPoints;
		[SerializeField]
		private float[] m_lineWidths;
		[SerializeField]
		private float m_lineWidth;
		[SerializeField]
		private float m_maxWeldDistance;
		[SerializeField]
		private float[] m_distances;
		[SerializeField]
		private string m_name;
		[SerializeField]
		private Material m_material;
		[SerializeField]
		private Texture m_originalTexture;
		[SerializeField]
		private Texture m_texture;
		[SerializeField]
		private bool m_active;
		[SerializeField]
		private LineType m_lineType;
		[SerializeField]
		private float m_capLength;
		[SerializeField]
		private bool m_smoothWidth;
		[SerializeField]
		private bool m_smoothColor;
		[SerializeField]
		private Joins m_joins;
		[SerializeField]
		private bool m_isAutoDrawing;
		[SerializeField]
		private int m_drawStart;
		[SerializeField]
		private int m_drawEnd;
		[SerializeField]
		private int m_endPointsUpdate;
		[SerializeField]
		private bool m_useNormals;
		[SerializeField]
		private bool m_useTangents;
		[SerializeField]
		private bool m_normalsCalculated;
		[SerializeField]
		private bool m_tangentsCalculated;
		[SerializeField]
		private EndCap m_capType;
		[SerializeField]
		private string m_endCap;
		[SerializeField]
		private bool m_useCapColors;
		[SerializeField]
		private Color32 m_frontColor;
		[SerializeField]
		private Color32 m_backColor;
		[SerializeField]
		private float m_lineUVBottom;
		[SerializeField]
		private float m_lineUVTop;
		[SerializeField]
		private float m_frontCapUVBottom;
		[SerializeField]
		private float m_frontCapUVTop;
		[SerializeField]
		private float m_backCapUVBottom;
		[SerializeField]
		private float m_backCapUVTop;
		[SerializeField]
		private bool m_continuousTexture;
		[SerializeField]
		private Transform m_drawTransform;
		[SerializeField]
		private bool m_viewportDraw;
		[SerializeField]
		private float m_textureScale;
		[SerializeField]
		private bool m_useTextureScale;
		[SerializeField]
		private float m_textureOffset;
		[SerializeField]
		private bool m_useMatrix;
		[SerializeField]
		private Matrix4x4 m_matrix;
		[SerializeField]
		private bool m_collider;
		[SerializeField]
		private bool m_trigger;
		[SerializeField]
		private PhysicsMaterial2D m_physicsMaterial;
		[SerializeField]
		private bool m_alignOddWidthToPixels;
	}
}
