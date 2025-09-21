using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCommands : MonoBehaviour
{
    [SerializeField] int level;

    audioScript audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioScript>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            audioManager.PlaySFX(audioManager.restartLevel);

            SceneManager.LoadSceneAsync(7);
            SceneManager.LoadSceneAsync(level + 1, LoadSceneMode.Additive);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            audioManager.PlaySFX(audioManager.menuSelectNoise);

            SceneManager.LoadSceneAsync(7);
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        }
    }
}
