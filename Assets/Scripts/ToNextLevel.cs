using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    audioScript audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioScript>();
    }

    public void OnNextLevel(int curlevel)
    {
        SceneManager.LoadSceneAsync(7);
        SceneManager.LoadSceneAsync(curlevel + 1, LoadSceneMode.Additive);
        audioManager.PlaySFX(audioManager.menuSelectNoise);
    }
}
