using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
    public void LoadMenu()
    {
        GameManager.instance.Restart();
        GameManager.instance.level = 0;
        GameManager.instance.clearFoodPoint();
        GameManager.instance.level = 0;
        GameManager.instance.playersTurn = true;
        GameManager.instance.level = 0;
        GameManager.instance.InitialiseGame();
        GameManager.instance.level = 0;

        SceneManager.LoadScene("Menu");

    }

     public void RestartGame()
    {
        
        SceneManager.LoadScene("Main");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
