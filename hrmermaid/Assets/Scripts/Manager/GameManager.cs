using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject camera;
	public GameObject terrain;
	public GameObject player;
	public GameObject mermaid;
	public static Vector3 MAXBOUNDS = new Vector3(200f, 200f, 200f);
	public static Vector3 MINBOUNDS = new Vector3(-200f, -200f, -200f);

	// Use this for initialization
	void Start () {
		Instantiate (camera);	
		Instantiate (terrain).transform.localPosition = new Vector3(-250f, 0f, 0f);
		Instantiate (player);	
		Instantiate (mermaid);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
