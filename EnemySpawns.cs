using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval;
    public int maxEnemies;

    private float timer = 0.0f;
    private int currentEnemyCount = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval && currentEnemyCount < maxEnemies)
        {
            SpawnEnemy();
            timer = 0.0f;
        }
    }

    void SpawnEnemy()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 4.0f));
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        currentEnemyCount++;
    }

    public void OnEnemyDestroyed()
    {
        currentEnemyCount--;
    }
}
