using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public List<GameObject> clientPrefabs;

    public int numberOfClients = 10;


    public float dayDuration = 600f;


    public Transform spawnPoint;

    private float spawnInterval;
    private float timeSinceLastSpawn;
    private int clientsSpawned;

    void Start()
    {
      
        spawnInterval = dayDuration / numberOfClients;
        timeSinceLastSpawn = 0f;
        clientsSpawned = 0;

        StartCoroutine(SpawnClients());
    }

    IEnumerator SpawnClients()
    {
        while (clientsSpawned < numberOfClients)
        {
            yield return new WaitForSeconds(spawnInterval);


            GameObject clientPrefab = clientPrefabs[Random.Range(0, clientPrefabs.Count)];


            Instantiate(clientPrefab, spawnPoint.position, spawnPoint.rotation);

            clientsSpawned++;
        }
    }
}
