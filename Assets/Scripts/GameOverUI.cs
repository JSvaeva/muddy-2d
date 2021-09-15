using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPlanel;
    public GameObject menu;
    private bool isOn = false;
    void Update()
    {
        if (isOn)
        {
            return;
        }

        if (GameOver.isGameOver)
        {
            gameOverPlanel.SetActive(true);
            menu.SetActive(false);
            isOn = true;
        }
    }
}
