using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
  public GameObject Player;
  public Camera Camera;
  public float moveSpeed;
  
  private Rigidbody2D rb;
  private Vector2 moveVelocity;
  
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }
  
  public void Move() 
  {
    Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    moveVelocity = moveInput.normalized * moveSpeed;
  }

  private void FixedUpdate()
  {
    rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
  }
  
  private void Update()
  {
    Move();
    
  }
  //
  // public void MoveRight() // движение вправо
  // {
  //   if (Input.GetKeyDown(KeyCode.RightArrow))
  //   {
  //     rb.velocity = new Vector2(moveSpeed, 0);
  //   }
  // }
  //
  // public void MoveLeft() // движение влево 
  // {
  //   if (Input.GetKeyDown(KeyCode.LeftArrow))
  //   {
  //     rb.velocity = new Vector2(-moveSpeed, 0);
  //   }
  // }
  //
  // public void MoveDown()  // движение вниз 
  // {
  //   if (Input.GetKeyDown(KeyCode.DownArrow))
  //   {
  //     rb.velocity = new Vector2(0, -moveSpeed);
  //   }
  // }

  

 
}
