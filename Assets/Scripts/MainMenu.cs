using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public GameObject ExitPromptWindow;

    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        // DestroyBannerAd();
    }

    // void ShowBannerAd()
    // {
    //     AdManager.Instance.ShowBanner();
    // }

    // void DestroyBannerAd()
    // {
    //     AdManager.Instance.DestroyBanner();
    // }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            
            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            ShowExitPromptWindow();
        }
    }

    public void ShowExitPromptWindow()
    {
        ExitPromptWindow.SetActive(true);
    }

    public void DontShowExitPromptWindow()
    {
        ExitPromptWindow.SetActive(false);
    }

    // The code below is for Exit button

    public void QuitGame()
    {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }

    // The code below is for rating and more games button

    public void Rate()
    {
        Application.OpenURL("market://details?id=com.NRGames.Hyper.Maze");
    }

    public void MoreGames()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=6871369737371625685");
    }

}