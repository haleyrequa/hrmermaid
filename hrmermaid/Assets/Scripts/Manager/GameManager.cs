using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject cameraControl;
	public GameObject directionalLight;
	public GameObject terrainManager;
	public GameObject soundManager;
	public GameObject player;
	public GameObject mermaid;
	public static Vector3 MAXBOUNDS = new Vector3(200f, 200f, 200f);
	public static Vector3 MINBOUNDS = new Vector3(-200f, -200f, -200f);

	void Awake () {
		Instantiate (cameraControl);	
		Instantiate (directionalLight);	
		Instantiate (terrainManager).transform.localPosition = new Vector3(-250f, 0f, 0f);
		Instantiate (soundManager);
		Instantiate (player).transform.position = new Vector3(0f, 197f, 0f);	
		Instantiate (mermaid);	
	}

	void Update () {
		
	}
}
