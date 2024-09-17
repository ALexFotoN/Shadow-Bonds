using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movin : MonoBehaviour
{
  public GameObject Player;
  public Camera Camera;
  public float moveSpeed = 0.5f;
  
  public void MoveUp()
  {
    if (Input.GetKey(KeyCode.W))
    {
      Vector3 newPosition = Player.transform.position + Vector3.up * Time.deltaTime * moveSpeed;
      Player.transform.position = newPosition;
    }
  }

  public void MoveRight()
  {
    if (Input.GetKey(KeyCode.D))
    {
      Vector3 newPosition = Player.transform.position + Vector3.right * Time.deltaTime * moveSpeed;
      Player.transform.position = newPosition;
    }
  }
  
  public void MoveLeft()
  {
    if (Input.GetKey(KeyCode.A))
    {
      Vector3 newPosition = Player.transform.position + Vector3.left * Time.deltaTime * moveSpeed;
      Player.transform.position = newPosition;
    }
  }
  
  public void MoveDown()
  {
    if (Input.GetKey(KeyCode.S))
    {
      Vector3 newPosition = Player.transform.position + Vector3.down * Time.deltaTime * moveSpeed;
      Player.transform.position = newPosition;
    }
  }

  

  private void Update()
  {
    MoveUp();
    MoveRight();
    MoveLeft();
    MoveDown();
    
  }
}
