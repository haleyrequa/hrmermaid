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

	public void Travel (Vector3 direction) {
		
		transform.LookAt (transform.position + direction + transform.forward);
		transform.position += direction * cruisinSpeed;
//		cam.Turn (transform.rotation.y);
//		Debug.Log (transform.rotation.y + " >>> " + transform.eulerAngles.y);
		//cam.SetXAngle (transform.rotation.eulerAngles.y);
	}
}
