using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemy_spawnLocation;
    public GameObject enemyToSpawn;
    void Start()
    {
        Instantiate(enemyToSpawn, enemy_spawnLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
