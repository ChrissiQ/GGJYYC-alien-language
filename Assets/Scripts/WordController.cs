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

	public void EnablePartialMask (Image mask) {
		// First element
		if (masks.IndexOf(mask) == 0) {
			if (!masks[masks.IndexOf(mask)+1].enabled) {
				mask.enabled = true;
			} else {
				masks.ForEach(x => x.enabled = false);
			}
		}
		// Second -> Second-last element
		else if (masks.IndexOf(mask) > -1 && masks.IndexOf(mask) < masks.Count-1) {
			if (masks[masks.IndexOf(mask)-1].enabled && !mask.enabled && !masks[masks.IndexOf(mask)+1].enabled) {
				mask.enabled = true;
			} else {
				masks.ForEach(x => x.enabled = false);
			}
		// Last element
		} else {
			if (masks[masks.IndexOf(mask)-1].enabled && !mask.enabled) {
				mask.enabled = true;
			} else {
				masks.ForEach(x => x.enabled = false);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (masks.TrueForAll(x => x.enabled)) {
			maskComplete.enabled = true;
		}
	}
}
