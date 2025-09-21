using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
    }
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}