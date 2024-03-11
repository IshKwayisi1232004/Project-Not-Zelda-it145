using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void onMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private Vector3 RemoveDiagonal(Vector3 inputVector)
    {
        float X = inputVector.x;
        float Y = inputVector.y;
    if (X * X > Y * Y)
        {
            return new Vector3(X, 0, 0);
        }
        else
        {
            return new Vector3(0, Y, 0);
        }
    }
}
