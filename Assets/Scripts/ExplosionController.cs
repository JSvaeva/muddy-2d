using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplosionController : MonoBehaviour
{
    public GameObject explosion;
    public GameObject canvas;
    public Text timerText;
    public float canExplodeAfter = 3f;
    public bool canExplode = false;
    public float harmAmount = 10f;

    private float deleteAfterExplosionTime = 3f;
    private float canExplodeTimer = 0f;

    private void Update()
    {
        if (GameOver.isGameOver)
        {
            return;
        }

        if (canExplodeTimer < canExplodeAfter)
        {
            canExplodeTimer += Time.deltaTime;
            timerText.text = (canExplodeAfter - canExplodeTimer).ToString("N2");
            if (canExplodeTimer >= canExplodeAfter)
            {
                canExplode = true;
                canvas.SetActive(false);
            }
        }
    }

    public void Explode()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        explosion.SetActive(true);
        Destroy(gameObject, deleteAfterExplosionTime);
    }
}
