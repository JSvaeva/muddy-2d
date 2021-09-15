using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool isGameOver = false;

    private void OnDestroy()
    {
        isGameOver = true;
    }
}
