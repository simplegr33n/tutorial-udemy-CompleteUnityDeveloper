using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour {

    private EnemyLaser enemyLaser;

    public float speed = 10f;

    // Use this for initialization
    void Start () {
        enemyLaser = GameObject.FindObjectOfType<EnemyLaser>();
        GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {

        //TODO: impact with enemies/leaving the screen behavior

        transform.position += Vector3.down * speed * Time.deltaTime;



    }

    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Enemy Laser Hit");

        if (collision.gameObject.tag == "EnemyIgnore")
        {
         //   EnemyShip enemyShip = GameObject.FindObjectOfType<EnemyShip>();
        //    Physics.IgnoreCollision(enemyLaser.GetComponent<Collider>(), enemyShip.GetComponent<Collider>());
        }

        if (collision.gameObject.tag != "EnemyIgnore") { 

                Destroy(gameObject);
        }

    }
}
