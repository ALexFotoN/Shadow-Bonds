using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enem : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public float radius;
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    
    // private bool onradius;
    // private bool isMoving;
    // private bool ontriger;
    // private float distance;
    // private EnemySpawner spawner;
    
    private void Start()
    {
        // spawner = FindAnyObjectByType<EnemySpawner>();
        
        left.SetActive(false);
        right.SetActive(false);
        up.SetActive(false);
        down.SetActive(true);
        
    }

    // private void OnDestroy()
    // {
    //     if (spawner != null)
    //     {
    //         spawner.OnEnemyDestroyed();
    //     }
    // }

    private void Update()
    {
        // distance = Vector2.Distance(transform.position, Player.transform.position);
        // Vector2 direction = Player.transform.position - transform.position;
        // if (distance < 20)
        // {
        //     transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        // }
        Enemysidex();
        // EnemySidey();
    }

    public void Enemysidex()
    {
        if (Player.transform.position.x > transform.position.x)
        {
            left.SetActive(false);
            right.SetActive(true);
            up.SetActive(false);
            down.SetActive(false);
        }

        if (Player.transform.position.x < transform.position.x)
        {
            left.SetActive(true);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
        }
    }

    // public void EnemySidey()
    // {
    //     if (Player.transform.position.y > transform.position.y)
    //     {
    //         left.SetActive(false);
    //         right.SetActive(false);
    //         up.SetActive(true);
    //         down.SetActive(false);
    //     } 
    //     
    //     if (Player.transform.position.y < transform.position.y)
    //     {
    //         left.SetActive(false);
    //         right.SetActive(false);
    //         up.SetActive(false);
    //         down.SetActive(true);
    //     }
    // }
    
    
    // private void Update()
    // {
    //     distance = Vector2.Distance(transform.position, Player.transform.position);
    //     Vector2 direction = Player.transform.position - transform.position;
    //         
    //     transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    // }

    // private void OnTriggerEnter(Collider collision)
    // {
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //         StartCoroutine(FollowPlayerRoutine());
    //     }
    // }
    //
    // IEnumerator FollowPlayerRoutine()
    // {
    //     while (true)
    //     {
    //         distance = Vector2.Distance(transform.position, Player.transform.position);
    //         Vector2 direction = Player.transform.position - transform.position;
    //         transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    //         yield return new WaitForEndOfFrame();
    //     }
    // }
}
