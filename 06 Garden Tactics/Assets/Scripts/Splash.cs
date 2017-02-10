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
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndChangeLevel Finishes 0.0"
        // - After 2 seconds, prints "WaitAndChangeLevel 2.0"
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndChangeLevel(splashWait);
        StartCoroutine(coroutine);

        print("Before WaitAndChangeLevel Finishes " + Time.time);
    }

    // Start level after waitTime
    private IEnumerator WaitAndChangeLevel(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndChangeLevel " + Time.time);

            levelManager.LoadLevel("Start");
        }
    }
}