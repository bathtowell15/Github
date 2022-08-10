using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2.5f);
    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            Random.Range(-2.2f, 3.2f),
            transform.position.z
            );
        Instantiate(
            enemyPrefab,
            spawnPosition,
            transform.rotation
            );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
