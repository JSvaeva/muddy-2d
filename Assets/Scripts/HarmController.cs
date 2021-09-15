using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmController : MonoBehaviour
{
    public float health = 10f;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Bomb")
        {
            ExplosionController bomb = other.GetComponent<ExplosionController>();
            if (bomb.canExplode)
            {
                health -= bomb.harmAmount;
                bomb.Explode();
            }
        }
        if (other.tag == "Enemy")
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            health -= enemy.harmAmount;
        }
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
