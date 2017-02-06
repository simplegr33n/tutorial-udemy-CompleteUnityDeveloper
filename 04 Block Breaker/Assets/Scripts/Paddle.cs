using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool autoPlay = false;

    private Ball ball;

	// Use this for initialization
	void Start () {

        ball = GameObject.FindObjectOfType<Ball>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!autoPlay)
        {
            MoveWithMouse();
        } else if (autoPlay)
        {
            MoveWithBall();
        }

	}

    void MoveWithMouse()
    {
        float mousePositionInBlocks = (float)Input.mousePosition.x / Screen.width * 16;

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

    void MoveWithBall()
    {

        float ballPositionInBlocks = (float)ball.transform.position.x;

        this.transform.position = new Vector3(Mathf.Clamp(ballPositionInBlocks, 0.5f, 15.5f), 0.5f, 0);

    }
}
