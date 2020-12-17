using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    private float spawnRangeY = 4.5f;
    private float spawnPosX = 16f;
    private float startDely = 5f;
    private float spawnInterval = 6f;

    void Start()
    {
        InvokeRepeating("SpawnRandomObstacles", startDely, spawnInterval);
    }

    void SpawnRandomObstacles()
    {
        int objectIndext = Random.Range(0, prefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY), 0);

        Instantiate(prefabs[objectIndext], spawnPos, prefabs[objectIndext].transform.rotation);
    }
}
