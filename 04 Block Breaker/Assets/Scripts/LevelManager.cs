using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {

        Brick.breakableCount = 0;


        SceneManager.LoadScene(name);
        Debug.Log(name + " Loaded...");

        
    }

    public void LoadNextLevel()
    {

        Brick.breakableCount = 0;

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

