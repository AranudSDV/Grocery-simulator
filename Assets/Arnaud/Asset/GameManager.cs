using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public List<GameObject> clientPrefabs;

    public int numberOfClients;
    public int NombreDeClientInWorld;


    public float dayDuration = 0f;
    public float NombreJours = 0f;
    public float TempsRestant;


    public Transform spawnPoint;

    private float spawnInterval;
    private float timeSinceLastSpawn;
    private int clientsSpawned;
    

    public GameObject EcranFinJOurnee;
    public TMP_Text TextJour;

    public TMP_Text TextPret;
    public TMP_Text TextMoneyDay;
    
    public TMP_Text TextHeure;
    public GameObject Player;
    public GameObject PlayerTpMatin;

    private bool TimerOn;

    public MoneyManagment MoneyManagment;
    public GameObject EcranFin;

    public Material ShaderAtlas;
    public float TempsPret;

    public float MoneyMakeDay;
    public float MoneyDayStart;

    public GameObject Rain;
    public GameObject Cloud;
    public bool JourneeFini;
    
    



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
        if(JourneeFini == true)
        {
            TextHeure.text = "Journee fini Encaisse tous les clients";
            if(NombreDeClientInWorld == 0)
            {
                StartCoroutine(CFinJournee());
            }
        }
        
        if(NombreJours <= 10)
        {
            TempsPret = 10f;
        }
        if(NombreJours > 10 && NombreJours <= 20)
        {
            TempsPret = 20f;
        }
        if(NombreJours > 20 && NombreJours <= 30)
        {
            TempsPret = 30f;
        }
        
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
            
            if(NombreDeClientInWorld < 4)
            {
                GameObject clientPrefab = clientPrefabs[Random.Range(0, clientPrefabs.Count)];

                Instantiate(clientPrefab, spawnPoint.position, spawnPoint.rotation);

                NombreDeClientInWorld++;
                clientsSpawned++;
            }
        }
            
           
    }

    IEnumerator Journee()
    {
        MoneyDayStart = MoneyManagment.Money;
        yield return new WaitForSeconds(dayDuration);
        
        if(NombreJours == 10)
        {
            if(MoneyManagment.Money < 300)
            {
                StartCoroutine(FInGame());
            }
            if(MoneyManagment.Money > 300)
            {
                MoneyManagment.Money = MoneyManagment.Money - 300;
                ShaderAtlas.SetFloat("_Saturation", 0.3f);
                Rain.SetActive(false);

            }
        }
        if(NombreJours == 20)
        {
            if(MoneyManagment.Money < 300)
            {
                StartCoroutine(FInGame());
            }
            if(MoneyManagment.Money > 300)
            {
                MoneyManagment.Money = MoneyManagment.Money - 300;
                ShaderAtlas.SetFloat("_Saturation", 0.6f);
                Cloud.SetActive(false);

            }
        }
        if(NombreJours == 30)
        {
            if(MoneyManagment.Money < 300)
            {
                StartCoroutine(FInGame());
            }
            if(MoneyManagment.Money > 300)
            {
                MoneyManagment.Money = MoneyManagment.Money - 300;
                ShaderAtlas.SetFloat("_Saturation", 1f);

            }
        }

        
        
        
        NombreJours = NombreJours + 1f;
        TextJour.text =  "jours " + NombreJours + " est fini !";

        float JourRestant = TempsPret - NombreJours;

        TextPret.text = "Dans " + JourRestant + " jours tu devras rembourser 300 Monux de pret a la banque";
        
        JourneeFini = true;
        

    }

    IEnumerator CFinJournee()
    {
        MoneyMakeDay = MoneyManagment.Money - MoneyDayStart;
        TextMoneyDay.text = "Aujourdhui tu as gagne " + MoneyMakeDay + " Monux";
        EcranFinJOurnee.SetActive(true);
        Player.GetComponent<CharacterController>().enabled = false;
        Player.transform.position = PlayerTpMatin.transform.position;

        JourneeFini = false;
        yield return new WaitForSeconds(7);
        EcranFinJOurnee.SetActive(false);
        Player.GetComponent<CharacterController>().enabled = true;
        
        RelanceJournee();
    }

    IEnumerator FInGame()
    {
        EcranFin.SetActive(true);
        yield return new WaitForSeconds(10);
        Application.Quit();
    }

    public void RelanceJournee()
    {
        clientsSpawned = 0;
        StartCoroutine(Journee());
        StartCoroutine(SpawnClients());
        TempsRestant = dayDuration;
    }
}
