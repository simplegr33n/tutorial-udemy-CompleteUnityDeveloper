using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // TODO: trigger this from brick, not here
    // Doesn't work like the unity vid at present for some reason.
    void Update()
    {
        BrickDestroyed();
    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
        Debug.Log(name + " Loaded...");
    }

    public void LoadNextLevel()
    {
      
        string next = null;

        Scene scene = SceneManager.GetActiveScene();

        print(scene.name + " is......");

        switch (scene.name)
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

    public void BrickDestroyed()
    {

        print("Brick.breakableCount: " + Brick.breakableCount);

        if (Brick.breakableCount <= 0)
        {
            print("Brick.breakableCount: " + Brick.breakableCount);
            LoadNextLevel();
        }
    }

}

