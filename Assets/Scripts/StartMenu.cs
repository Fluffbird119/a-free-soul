using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : MonoBehaviour
{
    
    public void OnPlayButton()
    {
        
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}