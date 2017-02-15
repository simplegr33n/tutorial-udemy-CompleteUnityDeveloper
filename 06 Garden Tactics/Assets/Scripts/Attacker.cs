using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    public float walkSpeed = 1f;

    private Vector3 newPosition;

    private bool moveStarted = false;

    private int moveNumber = 0;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (moveNumber <= TurnManager.turn && !moveStarted)
        {
            moveStarted = true;

            moveNumber += 1;

            genRandomDirection();

            InvokeRepeating("moveAttacker", 3.0f, 0.01f);

        }


        if (transform.position == newPosition)
        {

            moveStarted = false;

            CancelInvoke("moveAttacker");
        }

		
	}

    void genRandomDirection()
    {

        int r = Random.Range(1, 5);

        switch (r)
        {
            case 1: // Up

                if (transform.position.y < 8)
                {
                    newPosition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                }
                break;

            case 2: // Down
                if (transform.position.y > 1)
                {
                    newPosition = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
                }
                break;

            case 3: // Right
                if (transform.position.x < 8)
                {
                    newPosition = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                }
                break;

            case 4: // Left
                if (transform.position.x > 1)
                {
                    newPosition = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                }
                break;

          
        }

    }

    void moveAttacker()
    {

        transform.position = Vector3.MoveTowards(transform.position, newPosition, walkSpeed * Time.deltaTime);

    }
}
