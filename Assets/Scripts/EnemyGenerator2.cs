using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator2 : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 6f, 10.5f);
    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            //Random.Range(3.4f, 3.5f),
            3.5f,
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
