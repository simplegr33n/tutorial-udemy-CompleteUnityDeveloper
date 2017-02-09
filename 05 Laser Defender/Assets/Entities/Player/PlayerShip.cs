using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour {

    private int health = 3;

    public GameObject deathParticles;

    public LevelManager levelManager;

    public AudioClip explosion;

    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ship Hit");

        AudioSource.PlayClipAtPoint(explosion, transform.position, 1f);

        HandleHits();
    


    }


    void HandleHits()
    {
        health--;

        if (health <= 0)
        {

            GameObject death = Instantiate(deathParticles, transform.position, Quaternion.identity) as GameObject;


           // Destroy(gameObject);



            print("Player Lose");

            levelManager.LoadLevel("Lose");


            //   SimulateWin();
        }
        else
        {
            //Show a damaged ship

            //LoadSprites();
        }
    }


}