﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour { 

    private EnemyShip enemyShip;
    private int health = 2;

    public float fireRate = 0.99f;

    private float probability;

    public GameObject enemyLaser;

    public GameObject deathParticles;


    // Use this for initialization
    void Start () {

        enemyShip = GameObject.FindObjectOfType<EnemyShip>();

    }
	
	// Update is called once per frame
	void Update () {

        Fire();
        
		
	}

    void Fire()
    {
        
        if (Random.value >= fireRate)
        {
            Vector3 offset = new Vector3(0, 0.5f, 0);
            GameObject enemy = Instantiate(enemyLaser, transform.position - offset, Quaternion.identity) as GameObject;


        }
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


            GameObject death = Instantiate(deathParticles, transform.position, Quaternion.identity) as GameObject;


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
