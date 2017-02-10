using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class MusicPlayer : MonoBehaviour {

    public AudioClip startClip;

    private AudioSource music;

    void Awake() {

        // Start player
        music = GetComponent<AudioSource>();

        music.clip = startClip;
        music.loop = true;
        music.Play();

        DontDestroyOnLoad(music);
            
        print("MusicPlayer Created");
    }
    


    // Use this for initialization
    void Start() {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
