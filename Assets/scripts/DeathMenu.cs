using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{

    public GameObject DeathMenuUI;

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadMenu()
    {
       SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {
       Debug.Log("Quitting game...");
       DeathMenuUI.SetActive(false);
       Application.Quit();
    }
}
