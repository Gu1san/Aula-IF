using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float xOffset = 8f;
    
    void Start()
    {
        // Inicia o processo de spawn de inimigos repetidamente
        // O InvokeRepeating chama a função SpawnEnemy a cada 2 (spawnInterval) segundos, começando com 0 segundos de delay
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Gera uma posição aleatória para spawnar o inimigo dentro de um intervalo definido
        // O objeto com esse código já está na altura (y) que quero, então só preciso variar a posição x

        // Random.Range(-xOffset, xOffset) gera um valor aleatório entre -xOffset e xOffset (por padrão -8 e 8)
        Vector3 spawnPosition = new Vector3(Random.Range(-xOffset, xOffset), transform.position.y, 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
