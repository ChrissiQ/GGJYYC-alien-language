using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	[SerializeField] private Transform target;
	[SerializeField] private Vector3 offset;
	private float currentZoom = 10f;
	[SerializeField] private float pitch = 2f;

	void LateUpdate() {
		// Determine angle of the player, so the camera can be rotated around the player.
		float desiredAngle = target.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

		// Move position to the player
		transform.position = target.position - (rotation * offset * currentZoom);
		// Rotate to same angle as player.
		// https://code.tutsplus.com/tutorials/unity3d-third-person-cameras--mobile-11230
		transform.rotation = target.rotation;
		// Orient camera to look at back of player's head.
		transform.LookAt(target.position + Vector3.up * pitch);
	}

	public void MoveToFirstPerson() {
		pitch = 1;
		offset = new Vector3 (0, -0.1f, 0);
	}

	public void MoveToThirdPerson() {
		pitch = 2;
		offset = new Vector3 (0, -0.3f, 0.3f);
	}
}
