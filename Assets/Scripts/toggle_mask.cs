using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle_mask : MonoBehaviour {

	public Image mask;
	public GameObject[] words;

	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button>();
		button.onClick.AddListener( () => {
			foreach (GameObject word in words)
			{
				word.GetComponent<WordController>().EnablePartialMask(mask);
			}
		} );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
