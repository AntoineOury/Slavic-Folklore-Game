using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
  //Code written with help from ChatGPT and Unity Forum posts: 
  //https://discussions.unity.com/t/object-moving-on-xy-instead-of-xz/244892
  //https://forum.unity.com/threads/unity-input-system-move-along-z-axis.961165/
  
  public float moveSpeed = 5f;

  private Rigidbody2D rb;
  
  private SpriteRenderer m_SpriteRenderer;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    
    
    //get the SpriteRenderer from the Player GameObject to be able to access the flipX component
    m_SpriteRenderer = GetComponent<SpriteRenderer>();
  }

  void Update()
  {
    // Player movement along the X axis
    float moveX = Input.GetAxis("Horizontal");

    // Player movement along the Z axis
    float moveZ = Input.GetAxis("Depth");

    // Calculate movement vector
    // Vector2 movement = new Vector2(moveX, 0f) * moveSpeed * Time.deltaTime;
    //
    // transform.position += new Vector3(0f, 0f, moveZ) * moveSpeed * Time.deltaTime;
    
    Vector2 horizontalMovement = new Vector2(moveX, 0f) * moveSpeed * Time.deltaTime;
    Vector3 depthMovement = new Vector3(0f, 0f, moveZ) * moveSpeed * Time.deltaTime;



    // Apply movement
    rb.MovePosition(rb.position + horizontalMovement);
    transform.position += depthMovement;
    
    
    
    
    //if player is moving left (negative moveX) sprite flipX = true

    if (moveX < 0)
    {
      m_SpriteRenderer.flipX = true;
    }
    else if (moveX > 0)
    {
      m_SpriteRenderer.flipX = false;
    }
    
  }
  
}



