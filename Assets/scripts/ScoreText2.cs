﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreText2 : MonoBehaviour
{
     public static int scoreValue = 0;
     Text Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + scoreValue;

        if(scoreValue == 220)
        {
          SceneManager.LoadScene("Finish");
        }
    }
}
