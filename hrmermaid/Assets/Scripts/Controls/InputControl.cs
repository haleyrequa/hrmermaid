﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour {

	Player player;
	CameraControls camera;

	void Start() {
		camera = Camera.main.GetComponent <CameraControls>();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player>();
	}

	void Update() {


		if (Input.GetKey (KeyCode.W)) {
			player.Travel (Vector3.forward);
//			camera.TurnDirection(Vector3.forward);
		}

		if (Input.GetKey(KeyCode.A)) {
			player.Travel (Vector3.left);
			camera.TurnDirection(Vector3.left);
		}

		if (Input.GetKey (KeyCode.S)) {
			player.Travel (Vector3.back);
//			camera.TurnDirection(Vector3.back);
		}

		if (Input.GetKey(KeyCode.D)) {
			player.Travel (Vector3.right);
			camera.TurnDirection(Vector3.right);
		}

		if (Input.GetKey(KeyCode.UpArrow))
			player.Travel (Vector3.up);

		if (Input.GetKey(KeyCode.DownArrow))
			player.Travel (Vector3.down);

		if (Input.GetKeyUp (KeyCode.LeftArrow))
			camera.Turn (0f);

		if (Input.GetKeyDown (KeyCode.LeftArrow))
			camera.Turn (-1f);
//			player.Turn (-1f);
		//			camera.SetXAngle (-1f);

		if (Input.GetKeyUp (KeyCode.RightArrow))
			camera.Turn (0f);

		if (Input.GetKeyDown (KeyCode.RightArrow))
			camera.Turn (1f);
//			player.Turn(1f);
//			camera.SetXAngle (1f);
	}

}

