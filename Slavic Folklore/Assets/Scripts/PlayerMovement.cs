using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
    
    //Code from this amazing tutorial: https://youtu.be/cqNBA9Pslg8?si=9bRwbo8D6tvZeWQo
    {
    public float speed;
    public float groundDist;
    public LayerMask terrainLayer;
    public Rigidbody rb;
    public Animator animator; // Add Animator variable
    public GameObject walkingSprite; // Reference to the GameObject containing the walking sprite

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>(); // Get the Animator component
    }

    private void Update()
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

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(x, 0, y);
        rb.velocity = moveDir * speed;

        animator.SetBool("isWalking", moveDir.magnitude > 0); // Set isWalking based on movement magnitude
        
        if (moveDir.x < 0)
        {
            walkingSprite.transform.localScale = new Vector3(-1, 1, 1); // Flip sprite if moving left
        }
        else if (moveDir.x > 0)
        {
            walkingSprite.transform.localScale = new Vector3(1, 1, 1); // Reset scale if moving right
        }
    }
}

