using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public float enemySpawnX = 22f;
    public float enemySpawnZ = 12f;
    private float spawnDelay = 5f;
    private float spawnInterval = 2f;


    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);
        
    }
    

    void SpawnEnemy()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-enemySpawnX, enemySpawnX), 0, enemySpawnZ);
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], SpawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        Debug.Log("Spawn");
    }
    
    
}
