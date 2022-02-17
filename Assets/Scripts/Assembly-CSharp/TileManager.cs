using UnityEngine;
using System.Collections.Generic;

public class TileManager : MonoBehaviour
{
	public bool debagMode;
	public bool beginMapInit;
	public List<TileMap> visibleTiles;
	public List<TileMap> invisibleTiles;
	public int[] scales;
	public float[] scalesFloat;
	public float[] scalesObjectFloat;
	public List<TileMap> tilesZoomed;
	public List<TileMap> tilesZoomedGems;
	public List<GameObject> mainsGems;
	public int relativeZoom;
	public GameObject actualGem;
	public Sprite emptySprite;
}
