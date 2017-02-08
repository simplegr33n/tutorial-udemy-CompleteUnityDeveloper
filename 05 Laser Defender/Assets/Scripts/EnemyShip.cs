using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour {


    private EnemyShip enemyShip;

    // Use this for initialization
    void Start () {

        enemyShip = GameObject.FindObjectOfType<EnemyShip>();

        print("enemyship.transform.x: " + transform.position.x);
        print("enemyship.transform.y: " + transform.position.y);
        print("enemyship.transform.z: " + transform.position.z);

    }
	
	// Update is called once per frame
	void Update () {

    
		
	}
}
