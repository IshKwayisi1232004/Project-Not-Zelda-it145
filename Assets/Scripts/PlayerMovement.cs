using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    public GameObject footstep;

    Vector2 movement;

    private void Start()
    {
        footstep.SetActive(false);
    }



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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            footsteps();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            footsteps();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            footsteps();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            footsteps();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            stopFootSteps();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            stopFootSteps();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            stopFootSteps();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            stopFootSteps();
        }

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

    void footsteps()
    {
        footstep.SetActive(true);
    }

    void stopFootSteps()
    {
        footstep.SetActive(false);
    }
}
