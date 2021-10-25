using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject [] munitionPrefab;
    public float startDelay = 2f;
    public float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullets", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBullets()
    {
        int bulletIndex = Random.Range(0, munitionPrefab.Length);
        Instantiate(munitionPrefab[bulletIndex], transform.position, munitionPrefab[bulletIndex].transform.rotation);

    }



}