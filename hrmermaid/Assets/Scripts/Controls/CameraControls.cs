using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

	public Transform player;
	private Vector3 offset;

	private Vector3 axis = Vector3.up;
	public float turnSpeed = 1f;
	public float angle = 0f;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		offset = transform.position - player.position;
	}

	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		Debug.Log(angle);
		offset = Quaternion.AngleAxis (angle * turnSpeed, axis) * offset;
		transform.position = player.position + offset; 
		transform.LookAt(player.position);

//		angle = 0f;
		axis = Vector3.zero;
	}

	public void SetXAngle(float angle){
		this.angle = angle;
		axis = Vector3.up;
	}
}
