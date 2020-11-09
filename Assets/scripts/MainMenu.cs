using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Level_1()
    {
       SceneManager.LoadScene("Level 1");
    }
     
     public void Level_2()
    {
       SceneManager.LoadScene("2 player");
    }

    public void QuitGame()
    {
       Debug.Log("Quitting game...");
       Application.Quit();
    }

    public void LoadMenu()
    {
       SceneManager.LoadScene("Main_Menu");
    }
}
