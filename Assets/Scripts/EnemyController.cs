using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float visionRadius = 3f;
    public float hitRadius = 0.3f;
    public float speed = 1f;
    public float harmAmount = 5f;

    private GameObject player;
    private Animator anim;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (GameOver.isGameOver)
        {
            return;
        }

        float distanceToPlayer = Mathf.Abs(transform.position.magnitude - player.transform.position.magnitude);
        Vector2 movement = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        if (distanceToPlayer <= visionRadius)
        {
            Vector2 currentPos = new Vector2(transform.position.x, transform.position.y);
            Vector2 dir = (movement - currentPos).normalized;
            Vector2 axis = new Vector2(1, 0);

            float angle = Vector2.SignedAngle(axis, dir);

            transform.position = movement;

            float hor = 0;
            float ver = 0;

            if (angle <= 45 && angle >= -45)
            {
                hor = 1;
            }
            else if (angle > 45 && angle <= 135)
            {
                ver = 1;
            }
            else if (angle > 135 || angle <= -135)
            {
                hor = -1;
            }
            else
            {
                ver = -1;
            }

            anim.SetFloat("Horizontal", hor);
            anim.SetFloat("Vertical", ver);
        }
    }
}
