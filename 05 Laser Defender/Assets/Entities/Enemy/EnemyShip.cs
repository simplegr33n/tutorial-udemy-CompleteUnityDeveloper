using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour { 

    private EnemyShip enemyShip;
    private int health = 2;

    // Use this for initialization
    void Start () {

        enemyShip = GameObject.FindObjectOfType<EnemyShip>();

    }
	
	// Update is called once per frame
	void Update () {

    
		
	}

    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ship Hit");

        HandleHits();
       
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");

    }


    void HandleHits()
    {
        health--;

        if (health <= 0)
        {

            Destroy(gameObject);


            print("Enemy Down");


            //   SimulateWin();
        }
        else
        {
            //Show a damaged ship

            //LoadSprites();
        }
    }


}
