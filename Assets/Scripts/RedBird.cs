using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBird : MonoBehaviour {

    AudioSource aSource;

	// Use this for initialization
	void Start () {
        aSource = GetComponent<AudioSource>();
        aSource.PlayDelayed(Random.Range(15,45));
     }
	
	// Update is called once per frame
	void Update () {
		if (!aSource.isPlaying) {
            aSource.PlayDelayed(Random.Range(15, 45));
        }
    }
}
