using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour {

	Transform player;

	void Awake() {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update() {
		

		if (Input.GetKeyUp ("w"))
			player.localPosition += new Vector3 ();

		if (Input.GetKeyUp("a"))
			player.localPosition += new Vector3 ();
			

	}
}
