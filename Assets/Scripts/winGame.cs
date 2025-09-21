using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winGame : MonoBehaviour
{
    public GameObject cage;

    public GameObject backToLevelSelectButton;
    public GameObject nextLevelButton;
    public GameObject youEscapedText;

    public GameObject beforeYouWin;
    void Start()
    {
        beforeYouWin.SetActive(true);

        backToLevelSelectButton.SetActive(false);
        nextLevelButton.SetActive(false);
        youEscapedText.SetActive(false);
    }

    void Update()
    {
        if (cage == null)
        {
            beforeYouWin.SetActive(false);

            youEscapedText.SetActive(true);
            backToLevelSelectButton.SetActive(true);
            nextLevelButton.SetActive(true);
        }
    }
}
