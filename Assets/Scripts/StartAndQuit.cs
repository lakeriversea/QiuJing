﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAndQuit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  public  void StartGame()
    {
        SceneManager.LoadScene(1);
    }
   public void Quit()
    {
        Application.Quit();
    }
}
