using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX;
    private float movementY;


    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue) {

        Vector2 movementVector2 = movementValue.Get<Vector2>();
        movementX = movementVector2.x;
        movementY = movementVector2.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement);
        
    }

}
