using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public List<GameObject> clientPrefabs;

    public int numberOfClients = 10;


    public float dayDuration = 0f;
    public float NombreJours = 0f;
    public float TempsRestant;


    public Transform spawnPoint;

    private float spawnInterval;
    private float timeSinceLastSpawn;
    private int clientsSpawned;
    

    public GameObject EcranFinJOurnee;
    public TMP_Text TextJour;
    public TMP_Text TextHeure;
    public GameObject Player;
    public GameObject PlayerTpMatin;

    private bool TimerOn;

    
    



    void Start()
    {
        TimerOn = true;
        spawnInterval = dayDuration / numberOfClients;
        timeSinceLastSpawn = 0f;
        clientsSpawned = 0;
        

        StartCoroutine(SpawnClients());
        StartCoroutine(Journee());
        
    }

    public void Update()
    {
        
        if(TimerOn == true)
        {
            if(TempsRestant >0)
            {
                TempsRestant -= Time.deltaTime;
                UpdateTimer(TempsRestant);
            }
        }
        else
        {
            TempsRestant = 0;
            TimerOn = false;
        }
        
    }

    public void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float heure = Mathf.FloorToInt(currentTime / 60);
        float minutes = Mathf.FloorToInt(currentTime % 60);

        TextHeure.text = string.Format("{0:00} : {1:00}", heure, minutes);
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
        Player.GetComponent<CharacterController>().enabled = false;
        EcranFinJOurnee.SetActive(true);
        Player.transform.position = PlayerTpMatin.transform.position;
        NombreJours = NombreJours + 1f;
        TextJour.text =  "jours " + NombreJours;
        
        yield return new WaitForSeconds(5);
        EcranFinJOurnee.SetActive(false);
        Player.GetComponent<CharacterController>().enabled = true;

        RelanceJournee();

    }

    public void RelanceJournee()
    {
        StartCoroutine(Journee());
        TempsRestant = dayDuration;
    }
}
