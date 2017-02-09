using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {

        if (name.Equals("Start"))
        {
            // Reset ship and kill count whenever at Start screen
          
            RunningScore.Reset();
        }

        SceneManager.LoadScene(name);

        
    }

    public void LoadGame()
    {

        SceneManager.LoadScene("Game");

    }


}

