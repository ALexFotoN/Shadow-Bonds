using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject enemy;
    public float Time;

    private void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(Time);
        var clone = Instantiate(enemy, spawnPos.position, Quaternion.identity);
        clone.SetActive(true); // Добавили эту строку для активации копии объекта
        Repeat();
    }
}
