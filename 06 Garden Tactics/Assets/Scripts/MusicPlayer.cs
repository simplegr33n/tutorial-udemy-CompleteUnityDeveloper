using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class MusicPlayer : MonoBehaviour {

    public AudioClip[] musicClips;

    private AudioSource music;

    void Awake() {

        // Start player
        music = GetComponent<AudioSource>();

        music.volume = PlayerPrefsManager.GetMasterVolume();

        music.clip = musicClips[0];
        music.loop = true;
        music.Play();

        DontDestroyOnLoad(music);
            
    }

    void OnLevelWasLoaded(int level)
    {
     

        if (level == 3)
        {
            music.Stop();
            music.clip = musicClips[1];
            music.loop = true;
            music.Play();
        }

        if (level == 4)
        {
            music.Stop();
            music.clip = musicClips[0];
            music.loop = true;
            music.Play();
        }

        //TODO: lose will change from 5 to 7 probably
        if (level == 5)
        {
            music.Stop();
            music.clip = musicClips[2];
            music.loop = true;
            music.Play();
        }


    }

    public void SetVolume(float volume)
    {
        music.volume = volume;
    }



    // Use this for initialization
    void Start() {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
