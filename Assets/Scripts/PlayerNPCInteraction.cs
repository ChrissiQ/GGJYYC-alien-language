using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNPCInteraction : MonoBehaviour {

	[SerializeField] private Camera camera;
	[SerializeField] private GameObject player;

	// Use this for initialization
	void Start () {
		triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Cancel")) {
			triggered = false;
			camera.GetComponent<CameraController>().MoveToThirdPerson();
			player.GetComponent<SimpleCharacterControl>().start();
		}
	}

	private bool triggered = false;

	void OnTriggerEnter(Collider other) {
		if (!triggered && other.CompareTag("Player")) {
			Debug.Log("Hello!");
			triggered = true;
			camera.GetComponent<CameraController>().MoveToFirstPerson();
			player.GetComponent<SimpleCharacterControl>().stop();
		}
	}
	void OnTriggerStay(Collider other) {
		//Debug.Log ("stay");
	}
	void OnTriggerExit(Collider other) {
		if (triggered && other.CompareTag("Player")) {
			Debug.Log("Bye :-(");
			triggered = false;
			camera.GetComponent<CameraController>().MoveToThirdPerson();
		}
	}
}
