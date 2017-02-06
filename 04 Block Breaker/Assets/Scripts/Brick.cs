using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private bool isBreakable;

    private int timesHit;

    public static int breakableCount = 0;

    public AudioClip crack;

    public GameObject smoke;

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

        // Find LevelManager object
        levelManager = GameObject.FindObjectOfType<LevelManager>();


    }


    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(crack, transform.position, 0.1f);
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
            PuffSmoke();
            Destroy(gameObject);

           
            print("Breakable: " + breakableCount);


            //   SimulateWin();
        }
        else
        {
            LoadSprites();
        }
    }

    void PuffSmoke()
    {
        GameObject smokePuff = Instantiate(smoke, transform.position, Quaternion.identity) as GameObject;
        smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
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
