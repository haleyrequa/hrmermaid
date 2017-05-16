using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameEntity {

	CameraControls cam;
	public override float siteDepth { get { return 20f; } }
	public override float cruisinSpeed { get { return 20f; } }

	private float rotationSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		cam = Camera.main.GetComponent<CameraControls> ();
	}

	float speed = 10f;
	public void Travel (Vector3 direction) {
		transform.LookAt (transform.position + direction);
		transform.position += direction * speed;
		cam.SetXAngle (transform.rotation.eulerAngles.y);
	}
}
