using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelsMenu : MonoBehaviour
{
    public void OnLevelButton(int level)
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(level + 1, LoadSceneMode.Additive);
    }
    public void OnBackButton()
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
    }
}