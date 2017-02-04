using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private bool isBreakable;

    private int timesHit;

    public static int breakableCount = 0;

    public Sprite[] hitSprites;

    private LevelManager levelManager;


    // Use this for initialization
    void Start()
    {
        isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            breakableCount++;
        }

        timesHit = 0;

        print("Breakable: " + breakableCount);

    }


    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
     
        if (isBreakable)
        {
            HandleHits();
        }
    }

    void HandleHits()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;

      

        if (timesHit >= maxHits)
        {

            //TODO: get below working rather than calling BrickDestroyed in 
            // LevelManager Update
            breakableCount--;

            levelManager.BrickDestroyed();

            Destroy(gameObject);

            


            print("Breakable: " + breakableCount);


            //   SimulateWin();
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    //TODO: make sure is last block before win
    void SimulateWin() {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadNextLevel();
    }
}
