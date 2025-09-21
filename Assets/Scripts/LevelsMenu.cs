using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelsMenu : MonoBehaviour
{
    audioScript audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioScript>();
    }

    public void OnLevelButton(int level)
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(level + 1, LoadSceneMode.Additive);
        audioManager.PlaySFX(audioManager.menuSelectNoise);
    }
    public void OnBackButton()
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
        audioManager.PlaySFX(audioManager.menuSelectNoise);
    }
}