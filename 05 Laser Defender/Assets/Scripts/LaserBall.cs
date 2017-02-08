using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBall : MonoBehaviour {

    private LaserBall laserBall;

    public float speed = 10f;

    // Use this for initialization
    void Start () {
        laserBall = GameObject.FindObjectOfType<LaserBall>();
    }
	
	// Update is called once per frame
	void Update () {

        transform.position += Vector3.up * speed * Time.deltaTime;

    }
}
