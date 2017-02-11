using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManager levelManager;

    private MusicPlayer musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicPlayer>();

        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetMasterDifficulty();

    }
	
	// Update is called once per frame
	void Update () {

        musicManager.SetVolume(volumeSlider.value);
		
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetMasterDifficulty(difficultySlider.value);

        levelManager.LoadLevel("01a Start");

    }

    public void RestoreDefaults()
    {
        volumeSlider.value = 0.7f;
        difficultySlider.value = 1f;

    }
}
