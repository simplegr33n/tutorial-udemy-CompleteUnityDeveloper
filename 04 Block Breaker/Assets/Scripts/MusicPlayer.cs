using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class MusicPlayer : MonoBehaviour {
    
    // Udemy -
    // uses: static MusicPlayer instance = null;
    // and : instance = this; in Start()
    //
    // Maybe more elegant/robust than my solution

    static bool isOn = false;

    void Awake() {
        if (!isOn) {
            // Start player
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            GameObject.DontDestroyOnLoad(gameObject);
            isOn = true;
            print("MusicPlayer Created");
        } else {
            Destroy(gameObject);
            print("Redundant MusicPlayer Destroyed");
        }
    }

    // Use this for initialization
    void Start() {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
