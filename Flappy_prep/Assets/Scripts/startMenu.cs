using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    public bool isPaused = false;

    public GameObject PauseMenuUI;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           if(isPaused)
            {
                resume();
            }
           else
            {
                PauseMenu();
            }
        }
    }

     public void resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void PauseMenu()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }
    public void startButton()
    {
        SceneManager.LoadScene(1);
    }

   
}
