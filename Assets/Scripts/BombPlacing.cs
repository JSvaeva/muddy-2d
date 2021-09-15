using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlacing : MonoBehaviour
{
    public GameObject bomb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaceBomb();
        }
    }

    public void PlaceBomb()
    {
        Instantiate(bomb, transform.position, transform.rotation);
    }
}
