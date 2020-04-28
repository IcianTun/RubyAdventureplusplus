﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public void SelectScene()
    {
        switch (this.gameObject.name)
        {
            case "Scene1Button":
                SceneManager.LoadScene("Stage1Scene");
                break;
            case "Scene2Button":
                SceneManager.LoadScene("MezScene");
                break;
            case "Scene3Button":
                SceneManager.LoadScene("TunScene");
                break;
            case "Scene4Button":
                SceneManager.LoadScene("FightScene");
                break;
            case "Scene5Button":
                SceneManager.LoadScene("ZezeScene");
                break;
        }
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
