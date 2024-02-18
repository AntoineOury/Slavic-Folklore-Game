using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] private Rigidbody2D rb;
    // [SerializeField] private float speed = 5f;
    // private float moveHorizontal, moveVertical;
    //
    // private void Awake()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    // }
    //
    // private void FixedUpdate()
    // {
    //     moveHorizontal = Input.GetAxis("Horizontal") * speed;
    //     moveVertical = Input.GetAxis("Vertical") * speed;
    //     rb.velocity = new Vector2(moveHorizontal, moveVertical);
    // }
    

    //ChatGPT fixed code (above code has player move diagonally):
    public float moveSpeed = 3f;
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
    
        Vector2 inputDirection = new Vector2(horizontalInput, verticalInput).normalized;
        Vector2 movement = inputDirection * moveSpeed * Time.deltaTime;
    
        transform.Translate(movement);
    }


    
    
}
