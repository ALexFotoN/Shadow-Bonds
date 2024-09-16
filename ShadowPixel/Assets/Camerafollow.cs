using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
  private Transform Player;

  private void Start()
  {
    Player = GameObject.FindGameObjectWithTag("Player").transform;

  }

  private void LateUpdate()
  {
    Vector3 temp = transform.position;
    temp.x = Player.position.x;
    temp.y = Player.position.y;

    transform.position = temp;
  }
}
