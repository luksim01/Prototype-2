using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 10;
    private float spawnRangeZ = 6;
    private float spawnPosX = 17;

    private float startDelay = 2;
    private float startInterval = 1.5f;

    string[] animalDirection = { "down", "left", "right" };

    // Start is called before the first frame update
    void Start()
    {
        // randomly generate animal and spawn position every interval 
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int directionIndex = Random.Range(0, animalDirection.Length);

        // spawn animal in a random direction
        if(animalDirection[directionIndex] == "down")
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
                        animalPrefabs[animalIndex].transform.rotation);
        }
        else if(animalDirection[directionIndex] == "left")
        {
            Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(animalPrefabs[animalIndex], spawnPos,
                        Quaternion.LookRotation(Vector3.right));
        }
        else if (animalDirection[directionIndex] == "right")
        {
            Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(animalPrefabs[animalIndex], spawnPos,
                        Quaternion.LookRotation(Vector3.left));
        }
    }
}
