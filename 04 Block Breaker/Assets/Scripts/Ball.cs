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

                rigidBody.velocity = new Vector2(Random.Range(-0.1f,0.1f), 14f);
            }
        }
    }


    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Ball Trigger");
    }

    // Count times hit, Destroy gameObject if timeshit >= maxHits
    void OnCollisionEnter2D(Collision2D collision)
    {

        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f,0.2f));

        print("Ball Collision");

        if (isReleased)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
