using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour {


    private EnemyShip enemyShip;

    // Use this for initialization
    void Start () {

        enemyShip = GameObject.FindObjectOfType<EnemyShip>();

        print("enemyship.transform: " + enemyShip.transform.position.y);

    }
	
	// Update is called once per frame
	void Update () {

    
		
	}
}
