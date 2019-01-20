using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject Slider;
    
    

    void Start()
    {
        Slider.SetActive(false);
       
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
    

}
