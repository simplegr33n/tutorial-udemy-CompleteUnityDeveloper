using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    private PlayerShip playerShip;

    public GameObject laserBall;

    private float shipPosition = 0;

    public float changeRate = 10f;

    public float firingRate;

	// Use this for initialization
	void Start () {

        playerShip = GameObject.FindObjectOfType<PlayerShip>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("Right key was pressed");

            if (shipPosition < 6)
            {
                shipPosition += changeRate * Time.deltaTime;
                playerShip.transform.position = new Vector3(Mathf.Clamp((shipPosition), -15.5f, 15.5f), -4f, -1f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("Left key was pressed");

            if (shipPosition > -6)
            {
                shipPosition -= changeRate * Time.deltaTime;
                playerShip.transform.position = new Vector3(Mathf.Clamp((shipPosition), -15.5f, 15.5f), -4f, -1f);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            InvokeRepeating("Fire", 0.000001f, firingRate);

        }
        

        if (Input.GetKeyUp(KeyCode.Space))
        {
      
            CancelInvoke("Fire");
        
        }

    }

    void Fire()
    {
        GameObject beam = Instantiate(laserBall, playerShip.transform.position, Quaternion.identity) as GameObject;
    }
}
