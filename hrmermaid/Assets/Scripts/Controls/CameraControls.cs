using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

	public Transform player;
	private Vector3 offset;
	private Vector3 offsetR;
	private Vector3 turnDirection;

	private Vector3 axis = Vector3.up;
	public float turnSpeed = 1f;
	public float angle = 0f;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		offset = transform.position - player.position;
		offsetR = transform.position - player.position;
	}

	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.

		angle = (int)(player.eulerAngles.y) == (int)(transform.eulerAngles.y) ? 0f : (((int)player.eulerAngles.y) > (int)(transform.eulerAngles.y) ? 1f : -1f);

		int absDifference = Mathf.Abs((int)(transform.eulerAngles.y - player.eulerAngles.y));

		switch (absDifference) {
		case absDifference == 0:
			break;
		case absDifference < 180:
			break;
		case absDifference > 180:
			break;
			
		}
		if (absDifference == 0f) {
			angle = 0f;
		} else {
			angle = absDifference < 180 ? 
				(Mathf.Lerp(0f, 10f, Mathf.InverseLerp(0f, 180f, absDifference))) :
				(Mathf.Lerp(0f, 10f, Mathf.InverseLerp(360f, 180f, absDifference)));
		}

		if (turnDirection == Vector3.left) {
			angle = angle * -1f;
		} else if (turnDirection == Vector3.right) {
			angle = angle * 1f;
		}

		offset = Quaternion.AngleAxis (angle * turnSpeed, axis) * offset; // works but doesnt rotate around player
//		offset = Quaternion.AngleAxis (player.eulerAngles.y, axis) * offsetR; // Kinda works
		transform.position = player.position + offset; 
		transform.LookAt(player.position);

		angle = 0f;
//		axis = Vector3.zero;
	}

	public void Turn(float angle){
		this.angle = angle;
		axis = Vector3.up;
	}

	public void TurnDirection(Vector3 direction){
		turnDirection = direction;
	}

	public void Rotate(float angle) {
		this.angle = angle;
		axis = Vector3.up;
	}

}
