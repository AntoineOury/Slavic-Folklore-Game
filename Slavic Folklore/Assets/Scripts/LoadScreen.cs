using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    //code following: https://www.youtube.com/watch?v=wvXDCPLO7T0
    
    public GameObject LoadingScreen;

    public GameObject BG_Image;

    public GameObject Book_BG;


    public Image LoadingBarFill;


    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }


    IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        LoadingScreen.SetActive(true);

        BG_Image.SetActive(false);

        Book_BG.SetActive(false);

        
        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            LoadingBarFill.fillAmount = progressValue;
            yield return null;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
