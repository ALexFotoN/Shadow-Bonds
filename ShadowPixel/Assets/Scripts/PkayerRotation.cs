using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PkayerRotation : MonoBehaviour
{
  
  public GameObject left;
  public GameObject right;
  public GameObject up;
  public GameObject down;
  
  
  
  void Start()
  {
    left.SetActive(false);
    right.SetActive(false);
    up.SetActive(false);
    down.SetActive(true);
  }
  
   private void Update()
    {
      Left();
      Right();
      Up();
      Down();
      
    }

   
   
    public void Left()
    {
      if (Input.GetKeyDown(KeyCode.A))
      {
        left.SetActive(true);
        right.SetActive(false);
        up.SetActive(false);
        down.SetActive(false);
      }
    }
  
    public void Right()
    {
      if (Input.GetKeyDown(KeyCode.D))
      {
        left.SetActive(false);
        right.SetActive(true);
        up.SetActive(false);
        down.SetActive(false);
      }
    }
    
    public void Up()
    {
      if (Input.GetKeyDown(KeyCode.W))
      {
        left.SetActive(false);
        right.SetActive(false);
        up.SetActive(true);
        down.SetActive(false);
      }
    }
  
    public void Down()
    {
      if (Input.GetKeyDown(KeyCode.S))
      {
        left.SetActive(false);
        right.SetActive(false);
        up.SetActive(false);
        down.SetActive(true);
        
      }
    }
}
