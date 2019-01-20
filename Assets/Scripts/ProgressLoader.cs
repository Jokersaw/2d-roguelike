using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressLoader : MonoBehaviour {

    public GameObject LoadingScreen;
    public Slider slider;
    public Text ProgressText;
    public GameObject StartGameButton;
    public GameObject ExitButton;
    public GameObject SliderObject;

    public void Loader(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

       
        GameManager.instance.Restart();
        GameManager.instance.level = 0;
        GameManager.instance.clearFoodPoint();
        GameManager.instance.playersTurn = true;
        GameManager.instance.InitialiseGame();
        StartGameButton.SetActive(false);
        ExitButton.SetActive(false);
        SliderObject.SetActive(true);

        LoadingScreen.SetActive(true);




    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
      

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            ProgressText.text = progress * 100f + "%";

            yield return null;
        }
    }
}
