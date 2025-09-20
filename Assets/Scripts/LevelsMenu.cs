using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelsMenu : MonoBehaviour
{
    public void OnLevelButton(int level)
    {
        SceneManager.LoadScene(level + 1);
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }
}