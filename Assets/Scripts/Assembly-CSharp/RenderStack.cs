using UnityEngine;
using System.Collections.Generic;

public class RenderStack : MonoBehaviour
{
	[SerializeField]
	private List<TileMap> gameobjectsToRender;
	[SerializeField]
	private List<TileMap> gameobjectsToRenderError;
}
