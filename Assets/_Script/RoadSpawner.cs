using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    
    public GameObject roadPrefab;
    public GameObject player;
    public GameObject roadPos;
    protected GameObject roadCurrent;
    public float distance = 0f;


    public float distanceThreshold = 10f;
    private float lastSpawnPositionY;
    private void Awake()
    {
        
        roadPrefab = GameObject.Find("RoadPrefab");
        roadPos = GameObject.Find("RoadPos");
        player = GameObject.Find("Player");
        Spawn(roadPrefab.transform.position);
        //roadCurrent = roadPrefab;
    }

    private void FixedUpdate()
    {
        UpdateRoad();
    }

    protected void UpdateRoad()
    {
        //distance = Vector2.Distance(PlayerCtrl.instance.transform.position, roadCurrent.transform.position);
        //if(distance > 10)
        //{
        //    Spawn();
        //}
        float playerPositionY = player.transform.position.y;
        if (playerPositionY > lastSpawnPositionY + distanceThreshold)
        {
            Spawn();
        }
    }

    protected void Spawn()
    {
        //roadCurrent = Instantiate(roadPrefab, roadPos.transform.position, roadPrefab.transform.rotation);

        //Vector3 pos = roadPos.transform.position;
        //pos.x = 0;

        Vector3 spawnPosition = roadPos.transform.position;
        //spawnPosition.y = lastSpawnPositionY + distanceThreshold;
        spawnPosition.x = 0;
        Spawn(spawnPosition);
    }

    protected void Spawn(Vector3 pos)
    {
        roadCurrent = Instantiate(roadPrefab, pos, roadPrefab.transform.rotation);
        lastSpawnPositionY = pos.y;
    }


}
