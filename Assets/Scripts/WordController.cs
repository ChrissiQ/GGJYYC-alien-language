﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class WordController : MonoBehaviour {

	public List<Image> symbols;
	public bool known;

	// Use this for initialization
	void Start () {

	}

	public void EnableSymbolOnWord (string tagName) {

		if (!this.known) {
			Image symbol = symbols.Single(s => s.CompareTag(tagName));
			// First element
			if (symbols.IndexOf(symbol) == 0) {
				if (!symbols[symbols.IndexOf(symbol)+1].enabled) {
					symbol.enabled = true;
				} else {
					symbols.ForEach(x => x.enabled = false);
				}
			}
			// Second -> Second-last element
			else if (symbols.IndexOf(symbol) > -1 && symbols.IndexOf(symbol) < symbols.Count-1) {
				if (symbols[symbols.IndexOf(symbol)-1].enabled && !symbol.enabled && !symbols[symbols.IndexOf(symbol)+1].enabled) {
					symbol.enabled = true;
				} else {
					symbols.ForEach(x => x.enabled = false);
				}
			// Last element
			} else if (symbols.IndexOf(symbol) > -1) {
				if (symbols[symbols.IndexOf(symbol)-1].enabled && !symbol.enabled) {
					symbol.enabled = true;} else {
					symbols.ForEach(x => x.enabled = false);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (symbols.TrueForAll(x => x.enabled)) {
			this.known = true;
			symbols.ForEach(x => x.color = new Color(0.0F, 1.0F, 0.0F, 1.0F));
		}
	}
}
