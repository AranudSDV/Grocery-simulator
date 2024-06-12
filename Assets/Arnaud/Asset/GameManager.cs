using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public List<GameObject> clientPrefabs;

    public int numberOfClients = 10;


    public float dayDuration = 0f;


    public Transform spawnPoint;

    private float spawnInterval;
    private float timeSinceLastSpawn;
    private int clientsSpawned;

    public GameObject EcranFinJOurnee;


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

    IEnumerator Journee()
    {
        yield return new WaitForSeconds(dayDuration);
        EcranFinJOurnee.SetActive(true);
        
        yield return new WaitForSeconds(5);
        EcranFinJOurnee.SetActive(false);

    }
}
