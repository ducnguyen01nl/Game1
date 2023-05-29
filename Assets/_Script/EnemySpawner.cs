using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyPos;
    public GameObject player;
    public Vector3 enemyPosSpawn;
    public float spawnTimer = 0f;

    private void Awake()
    {
        enemyPrefab = GameObject.Find("EnemyPrefab");
        enemyPos = GameObject.Find("EnemyPos");
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        enemyPosSpawn = enemyPos.transform.position;
        Spawn();
       
    }

    protected virtual GameObject Spawn()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer < 2)
        {
            return null;
        }
        spawnTimer = 0;
        enemyPosSpawn.x = Random.Range(-3, 3);
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.position = enemyPosSpawn;
        enemy.transform.parent = transform;
        return enemy;

    }
}
