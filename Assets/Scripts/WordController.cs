using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordController : MonoBehaviour {

	public List<Image> masks;

	public Image maskComplete;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (masks.TrueForAll(x => x.enabled)) {
			maskComplete.enabled = true;
		}
	}
}
