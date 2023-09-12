using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    [SerializeField] private float jumpVelocity = 10f;
    [SerializeField] private float sidesVelocity = 5f;

    private static Rigidbody2D _rigidbody2d;
    
    // Setting the Transform and Usage of the RigidBody2D in gameObject logic for after
    private void Awake()
    {
        _rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jumping();
        RightLeftControl();
    }

    private void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Inside The If Statement that is Space Key Code");
            // here we are using Vector 2d for the up scale because we are handling the jump logic and we are equalizing the rigidbody velocity with this
            _rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }

    private void RightLeftControl()
    {
        // left side
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Left Side Move");
            _rigidbody2d.velocity = Vector2.left * sidesVelocity;
        }
        // right side
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Right Side Moved");
            _rigidbody2d.velocity = Vector2.right * sidesVelocity;
        }
    }
}
