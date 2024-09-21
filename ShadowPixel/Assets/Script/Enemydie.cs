using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydie : MonoBehaviour
{
   public int health;

   private void Update()
   {
      if (health <= 0)
      {
         Destroy(gameObject);
      }
   }

   public void TakeDamage(int damage)
   {
      health -= damage;
   }
   
}
