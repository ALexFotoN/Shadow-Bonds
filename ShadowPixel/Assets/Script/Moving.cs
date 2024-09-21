using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
  public float moveSpeed;
  
  private Rigidbody2D rb;
  private Vector2 moveVelocity;
  // public GameObject left;
  // public GameObject right;
  // public GameObject up;
  // public GameObject down;
  
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    // left.SetActive(false);
    // right.SetActive(false);
    // up.SetActive(false);
    // down.SetActive(true);
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
    // Left();
    // Right();
    // Up();
    // Down();
  }

  // public void Left()
  // {
  //   if (Input.GetKeyDown(KeyCode.A))
  //   {
  //     left.SetActive(true);
  //     right.SetActive(false);
  //     up.SetActive(false);
  //     down.SetActive(false);
  //   }
  // }
  //
  // public void Right()
  // {
  //   if (Input.GetKeyDown(KeyCode.D))
  //   {
  //     left.SetActive(false);
  //     right.SetActive(true);
  //     up.SetActive(false);
  //     down.SetActive(false);
  //   }
  // }
  //
  // public void Up()
  // {
  //   if (Input.GetKeyDown(KeyCode.W))
  //   {
  //     left.SetActive(false);
  //     right.SetActive(false);
  //     up.SetActive(true);
  //     down.SetActive(false);
  //   }
  // }
  //
  // public void Down()
  // {
  //   if (Input.GetKeyDown(KeyCode.S))
  //   {
  //     left.SetActive(false);
  //     right.SetActive(false);
  //     up.SetActive(false);
  //     down.SetActive(true);
  //   }
  // }
  
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
