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
            SceneManager.LoadScene(level + 1);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(1);
        }
    }
}
