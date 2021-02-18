using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SymbolController : MonoBehaviour {

	public Sprite symbol;
	public string symbolName;
	public string tagName;
	public GameObject GameController;

	// Use this for initialization
	void Start () {
		List<GameObject> words = GameController.GetComponent<GameController>().words;
		Button button = GetComponent<Button>();
		button.onClick.AddListener( () => {
			Debug.Log("hi");
			foreach (GameObject word in words)
			{
				var wordController = word.GetComponent<WordController>();
				wordController.EnableSymbolOnWord(tagName);
			}
		} );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
