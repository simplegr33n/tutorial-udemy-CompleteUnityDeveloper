using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class MusicPlayer : MonoBehaviour {
    
    // Udemy -
    // uses: static MusicPlayer instance = null;
    // and : instance = this; in Start()
    //
    // Maybe more elegant/robust than my solution

    static bool isOn = false;

    public AudioClip startClip;
    public AudioClip gameClip;

    private AudioSource music;

    void Awake() {
        if (!isOn) {
            // Start player
            music = GetComponent<AudioSource>();

            music.clip = startClip;
            music.loop = true;
            music.Play();

            DontDestroyOnLoad(music);
            isOn = true;
            print("MusicPlayer Created");
        } else {
            Destroy(gameObject);
            print("Redundant MusicPlayer Destroyed");
        }
    }

    void OnLevelWasLoaded(int level)
    {
        

        if (level == 1)
        {
            music.Stop();
            music.clip = gameClip;
            music.loop = true;
            music.Play();
        } else if (level == 2) {
            music.Stop();
            music.clip = startClip;
            music.loop = true;
            music.Play();
        } else if (level == 0)
        {
            // Do nothing when return to start, allow song to continue from level 2 (end)
         
        }
        
    }


    // Use this for initialization
    void Start() {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
