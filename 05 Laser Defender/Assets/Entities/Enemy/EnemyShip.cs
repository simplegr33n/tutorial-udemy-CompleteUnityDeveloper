using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour { 

    private EnemyShip enemyShip;
    private int health = 2;

    public int updateCap = 300;

    public GameObject enemyLaser;

    // TODO: Consider making a public static so whole formation shoots at given frequency 
    private int updateCount = 0;

    // Use this for initialization
    void Start () {

        enemyShip = GameObject.FindObjectOfType<EnemyShip>();

        // Start each ship at different offset
        updateCount = Random.Range(1, updateCap);

    }
	
	// Update is called once per frame
	void Update () {

        updateCount += 1;

        if (updateCount >= updateCap)
        {
            updateCount = 0;

            GameObject enemy = Instantiate(enemyLaser, transform.position, Quaternion.identity) as GameObject;

            print("yolo");

        }
        
		
	}

    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ship Hit");

        if (collision.gameObject.tag == "EnemyIgnore")
        {
            
            Physics.IgnoreCollision(enemyLaser.GetComponent<Collider>(), enemyShip.GetComponent<Collider>());
        }

        if (collision.gameObject.tag != "EnemyIgnore")
        {

            HandleHits();
        }
       
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
