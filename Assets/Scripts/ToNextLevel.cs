using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnNextLevel(int curlevel)
    {
        SceneManager.LoadScene(curlevel + 1);
    }
}
