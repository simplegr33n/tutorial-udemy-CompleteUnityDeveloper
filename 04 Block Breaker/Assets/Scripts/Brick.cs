using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Brick : MonoBehaviour
{

    private int timesHit;

    public Sprite[] hitSprites;

    private LevelManager levelManager;


    // Use this for initialization
    void Start()
    {
        timesHit = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
        bool isBreakable = (this.tag == "Breakable");
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
            Destroy(gameObject);

            SimulateWin();
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
    void SimulateWin()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();

        // OFF for now
        //
        //levelManager.LoadNextLevel(SceneManager.GetActiveScene());
    }
}
