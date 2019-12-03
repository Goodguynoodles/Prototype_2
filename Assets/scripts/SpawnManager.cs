using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour    
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangex = 10;
    private float spawnPosz = 20;
    private float startdelay = 2f;
    private float spawninterfall = 1.5f;

    private void Start()
    {
        InvokeRepeating("Spawnanimal", startdelay, spawninterfall);
    }

    void Update()
    {
    }

    void Spawnanimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex),0 ,spawnPosz);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
