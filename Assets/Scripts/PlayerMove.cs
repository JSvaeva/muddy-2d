using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1f;

    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDown();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + speed * Time.deltaTime * movement);
    }

    public void MoveUp()
    {
        movement.x = 0;
        movement.y = 1;
    }

    public void MoveDown()
    {
        movement.x = 0;
        movement.y = -1;
    }

    public void MoveLeft()
    {
        movement.x = -1;
        movement.y = 0;
    }

    public void MoveRight()
    {
        movement.x = 1;
        movement.y = 0;
    }
}
