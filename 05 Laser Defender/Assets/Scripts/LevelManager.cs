﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {


        SceneManager.LoadScene(name);

        
    }

    public void LoadGame()
    {

        SceneManager.LoadScene("Game");

    }


}
