using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour {

	public GameObject terrain;
	CameraControls cameraControls;
	Tile[] terrains;
	Bounds bounds;

	// Use this for initialization
	void Start () {

		Bounds cameraBounds = CameraExtensions.OrthographicBounds ();

		cameraBounds = CameraExtensions.OrthographicBoundsWorld ();
		Vector3 tileSize = terrain.GetComponent<Terrain>().terrainData.size;//new Vector3 (2f, 1f, 2f);
		int xCount = Mathf.Abs((int)((cameraBounds.max.x - cameraBounds.min.x) / tileSize.x)), // TODO rename width and make class variable
		yCount = 1,
		zCount = Mathf.Abs((int)((cameraBounds.max.z - cameraBounds.min.z) / tileSize.z));

		terrains = new Tile[xCount * yCount *  zCount];
//		terrains = new Tile[xCount, 1, zCount];

//		bounds = CameraExtensions.OrthographicBounds ().min;
		for (int tile = 0, x = 0; x < xCount; x++) {
			for (int y = 0; y < yCount; y++) {
				for (int z = 0; z < zCount; z++, tile++) {
					terrains [tile] = Instantiate (terrain).GetComponent<Tile> ();
					terrains [tile].transform.localPosition = new Vector3 (
						cameraBounds.min.x + ((float)x) * tileSize.x,
						0f,
						cameraBounds.min.z + ((float)z) * tileSize.z
					);
				}
			}
		}

//		while(!CameraExtensions.ContainBounds(bounds)) {
//			terrains[i]Instantiate(terrain).transform.position
//		}
	}

	// Update is called once per frame
	void Update () {

		if (!CameraExtensions.ContainBounds(bounds))
			ShiftTerrain ();
	}

	void ShiftTerrain() {
	
	}
}
