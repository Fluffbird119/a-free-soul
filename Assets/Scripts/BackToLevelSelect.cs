using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLevelSelect : MonoBehaviour
{
    public void OnBackToLevelSelect()
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }
}
