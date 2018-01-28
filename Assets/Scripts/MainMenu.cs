using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject plasma;

    public void PlayGame()
    {
        //Instantiate(plasma, transform.position, transform.rotation);
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
