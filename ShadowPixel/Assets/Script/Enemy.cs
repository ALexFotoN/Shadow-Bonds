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

    private bool onradius;
    private bool isMoving;
    private bool ontriger;
    private float distance;
    private EnemySpawner spawner;
    
    private void Start()
    {
        spawner = FindAnyObjectByType<EnemySpawner>();
    }

    private void OnDestroy()
    {
        if (spawner != null)
        {
            spawner.OnEnemyDestroyed();
        }
    }

    private void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
    
        // if (distance < radius && !isMoving)
        // {
        //     isMoving = true;
        //     
        //     // Перемещаем объект к игроку
        //     transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        // }
        // else if (distance >= radius && isMoving)
        // {
        //     // Продолжаем движение
        //     Vector2 positionAsVector2 = (Vector2)transform.position;
        //     transform.position = positionAsVector2 + (direction * speed * Time.deltaTime);
        // }
        
        // if (distance < radius)
        // {
        //     bool onradius = true;
        //     transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        //     
        // }
        //
        // if (onradius == false)
        // {
        //     transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        // }
        
        
        
        
        // if (distance < radius)
        // {
        //     // Начинаем движение, если объект входит в радиус
        //     if (!isMoving)
        //     {
        //         isMoving = true;
        //         
        //         // Перемещаем объект к игроку
        //         transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        //     }
        // }
        // else if (distance >= radius)
        // {
        //     // Продолжаем движение, если объект уже начал движение
        //     if (isMoving)
        //     {
        //         // Продолжаем движение
        //         Vector2 positionAsVector2 = (Vector2)transform.position;
        //         transform.position = positionAsVector2 + (direction * speed * Time.deltaTime);
        //     }
        // }
        
        if (distance < 20)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        }
        
    }


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
