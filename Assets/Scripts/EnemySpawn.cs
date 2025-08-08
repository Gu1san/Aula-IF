using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float xOffset = 5f;
    
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-xOffset, xOffset), transform.position.y, 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
