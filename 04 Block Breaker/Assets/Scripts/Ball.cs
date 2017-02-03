using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;

    private Vector3 paddleToBallVector;

    private bool isReleased = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();

        paddleToBallVector = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!isReleased) {
            // Lock ball relative to paddle until mouse press
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0)) {
                print("Mouse Clicked!");

                isReleased = true;

                Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

                rigidBody.velocity = new Vector2(0, 14f);
            }
        }
    }
}
