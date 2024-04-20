using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    //Code from this amazing tutorial: https://youtu.be/cqNBA9Pslg8?si=9bRwbo8D6tvZeWQo
    //And for sprite animation: https://www.youtube.com/watch?v=Sg_w8hIbp4Y&t=308s 
    
    
    public float speed;
    public float groundDist;
    public LayerMask terrainLayer;
    public Rigidbody rb;
    public SpriteRenderer sr;

    private Animator animator; 
    private FootstepController footstepController;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize Rigidbody and Animator
        rb = gameObject.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        // Get the FootstepController component from a child object
        footstepController = GetComponentInChildren<FootstepController>();
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 castPos = transform.position;
        castPos.y += 1;

        if (Physics.Raycast(castPos, -transform.up, out hit, Mathf.Infinity, terrainLayer))
        {
            if (hit.collider != null)
            {
                Vector3 movePos = transform.position;
                movePos.y = hit.point.y + groundDist;
                transform.position = movePos;
            }
        }

        // Movement input
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(x, 0, y);
        rb.velocity = moveDir * speed;

        // Update animator
        animator.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));

        // Flip sprite
        if (x != 0 && x < 0)
        {
            sr.flipX = true;
        }
        else if (x != 0 && x > 0)
        {
            sr.flipX = false;
        }

        // Check if the player is walking or not and call the appropriate methods
        if (rb.velocity.magnitude > 0)
        {
            footstepController.StartWalking();
        }
        else
        {
            footstepController.StopWalking();
        }
    }

}