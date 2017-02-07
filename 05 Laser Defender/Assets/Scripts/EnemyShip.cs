using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour {

    private bool moveRight = true;

    private float enemyPosition = 0;

    private EnemyShip enemyShip;

    // Use this for initialization
    void Start () {

        enemyShip = GameObject.FindObjectOfType<EnemyShip>();

    }
	
	// Update is called once per frame
	void Update () {

        if (enemyPosition >= 6)
        {
            moveRight = false;
        }

        if (enemyPosition <= -6)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            enemyPosition += 0.1f;
            enemyShip.transform.position = new Vector3(enemyPosition, 0f, -1f);
        }

        if (!moveRight)
        {
            enemyPosition -= 0.1f;
            enemyShip.transform.position = new Vector3(enemyPosition, 0f, -1f);
        }
		
	}
}
