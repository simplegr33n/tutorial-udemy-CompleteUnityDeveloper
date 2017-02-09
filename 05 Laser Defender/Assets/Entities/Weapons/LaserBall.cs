using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBall : MonoBehaviour {

    private LaserBall laserBall;

    public float speed = 10f;

    // Use this for initialization
    void Start () {
        laserBall = GameObject.FindObjectOfType<LaserBall>();
        GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {

        //TODO: impact with enemies/leaving the screen behavior

        transform.position += Vector3.up * speed * Time.deltaTime;



    }

    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Ball Hit");


        if (collision.gameObject.tag != "PlayerShip")
        {

            Destroy(gameObject);
        }
       

    }
}
