using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }



    //public Transform player;
    //public GameObject Player;
    //public float speed;

    //private bool ontriger;
    //private float distance;


    // private void Update()
    // {
    //     distance = Vector2.Distance(transform.position, Player.transform.position);
    //     Vector2 direction = Player.transform.position - transform.position;
    //         
    //     transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    // }

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        StartCoroutine(FollowPlayerRoutine());
    //    }
    //}

    //IEnumerator FollowPlayerRoutine()
    //{
    //    while (true)
    //    {
    //        distance = Vector2.Distance(transform.position, Player.transform.position);
    //        Vector2 direction = Player.transform.position - transform.position;
    //       transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    //        yield return new WaitForEndOfFrame();
    //    }
    //}
}
