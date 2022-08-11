using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator3 : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 3f, 7.5f);
    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            0.52f,
            transform.position.z
            );
        Instantiate(
            enemyPrefab,
            spawnPosition,
            transform.rotation
            );
    }

    // Update is called once per frame
   // void Update()
    //{

    //}
}
