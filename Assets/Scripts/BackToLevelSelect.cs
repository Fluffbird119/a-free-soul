using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLevelSelect : MonoBehaviour
{
    audioScript audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioScript>();
    }

    public void OnBackToLevelSelect()
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        audioManager.PlaySFX(audioManager.menuSelectNoise);
    }
}
