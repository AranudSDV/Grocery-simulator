using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Lore;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Loree()
    {
        Menu.SetActive(false);
        Lore.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
