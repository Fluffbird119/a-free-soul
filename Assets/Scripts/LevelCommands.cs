using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCommands : MonoBehaviour
{
    [SerializeField] int level;
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadSceneAsync(7);
            SceneManager.LoadSceneAsync(level + 1, LoadSceneMode.Additive);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadSceneAsync(7);
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        }
    }
}
