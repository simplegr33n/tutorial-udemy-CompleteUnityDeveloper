using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string MASTER_DIFFICULTY_KEY = "master_difficulty";

    // TODO: implement levels in Garden Tactics.
    const string LEVEL_KEY = "level_unlocked_";
   
    public static void SetMasterVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        } else
        {
            Debug.LogError("Master volume out of range");
        }
    }

    public static float GetMasterVolume()
    {

        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetMasterDifficulty(float difficulty)
    {
        if (difficulty >= 1f && difficulty <= 3f)
        {
            PlayerPrefs.SetFloat(MASTER_DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Master difficulty out of range");
        }
    }

    public static float GetMasterDifficulty()
    {
        return PlayerPrefs.GetFloat(MASTER_DIFFICULTY_KEY);
    }

    public static void UnlockLevel(int level)
    {
        // TODO: if level in range (catch error) ...

        PlayerPrefs.SetInt(LEVEL_KEY + level, 1); // Use 1 for true
    }

    public static bool IsLevelUnlocked(int level)
    {
        // TODO: if level in range (catch error) ...

        if (PlayerPrefs.GetInt(LEVEL_KEY + level) == 1)
        {
            return true;
        } else
        {
            return false;
        }
    }



}
