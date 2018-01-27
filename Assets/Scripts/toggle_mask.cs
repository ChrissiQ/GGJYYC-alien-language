using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle_mask : MonoBehaviour {

	public Image mask;

	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button>();
		button.onClick.AddListener( () => {
			mask.enabled = true;
		} );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
