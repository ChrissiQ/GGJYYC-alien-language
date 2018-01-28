using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNPCInteraction : MonoBehaviour {

	[SerializeField] private Camera camera;
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject musicUI;
	[SerializeField] private GameObject pressSpaceToTalk;
	[SerializeField] private GameObject thankYouText;
	[SerializeField] private GameObject magicRock;

	// Use this for initialization
	void Start () {
		triggered = false;
		musicUI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Cancel")) {
			triggered = false;
			camera.GetComponent<CameraController>().MoveToThirdPerson();
			player.GetComponent<SimpleCharacterControl>().start();
			musicUI.SetActive (false);
			//pressSpaceToTalk.SetActive (true);
			thankYouText.SetActive(false);
		}
		if(triggered && Input.GetButtonDown("Interact")) {
			Inventory pickup = player.GetComponent<Inventory> ();
			if(!pickup.apple) {
				camera.GetComponent<CameraController> ().MoveToFirstPerson ();
				player.GetComponent<SimpleCharacterControl> ().stop ();
				musicUI.SetActive (true);

				pressSpaceToTalk.SetActive (false);
			} else {
				// say thank you
				thankYouText.SetActive(true);

				magicRock.GetComponent<GuardPass> ().guardGo = true;

				pressSpaceToTalk.SetActive (false);
				// open bridge
			}

		}
	}

	private bool triggered = false;

	void OnTriggerEnter(Collider other) {
		if (!triggered && other.CompareTag("Player")) {
			Debug.Log("Hello!");
			triggered = true;
//			camera.GetComponent<CameraController>().MoveToFirstPerson();
//			player.GetComponent<SimpleCharacterControl>().stop();
//			musicUI.SetActive(true);
			pressSpaceToTalk.SetActive (true);
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
			player.GetComponent<SimpleCharacterControl>().start();
			musicUI.SetActive (false);
			pressSpaceToTalk.SetActive (false);
		}
	}
}
