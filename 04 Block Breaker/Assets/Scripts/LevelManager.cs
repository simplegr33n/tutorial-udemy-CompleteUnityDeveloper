using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
        Debug.Log(name + " Loaded...");
    }

    public void LoadNextLevel(Scene scene)
    {
        Debug.Log(scene + " is......");
        string next = null;

        switch(scene.name)
        {
            case "Level_01":
                next = "Level_02";
                break;

            case "Level_02":
                next = "Level_03";
                break;

            case "Level_03":
                next = "Win";
                break;

        }


        SceneManager.LoadScene(next);
        Debug.Log(next + " Loaded...");
    }

}

