using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{

    // In this example we show how to invoke a coroutine and 
    // continue executing the function in parallel.

    private IEnumerator coroutine;

    public LevelManager levelManager;

    public float splashWait = 2.0f;

    void Start()
    {
        // Much easier than using coroutine I think
        Invoke("LoadStart", splashWait);

    }

    void LoadStart()
    {
        levelManager.LoadLevel("Start");
    }
}
       