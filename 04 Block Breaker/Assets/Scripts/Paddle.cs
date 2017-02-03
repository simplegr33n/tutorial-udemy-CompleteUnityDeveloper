using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float mousePositionInBlocks = (float) Input.mousePosition.x / Screen.width * 16;

    //  REPLACED BY Mathf.Clamp() BELOW
    // 
    //    if (mousePositionInBlocks < 0.5) {
    //        mousePositionInBlocks = 0.5f;
    //    }
    //    else if (mousePositionInBlocks > 15.5) {
    //        mousePositionInBlocks = 15.5f;
    //    }

        this.transform.position = new Vector3(Mathf.Clamp(mousePositionInBlocks, 0.5f, 15.5f), 0.5f, 0);
		
	}
}
