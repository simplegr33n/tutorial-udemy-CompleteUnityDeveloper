using UnityEngine.SceneManagement;
using UnityEngine;

public class OtherManager : MonoBehaviour {

    public void LoadOther(string name) {
        SceneManager.LoadScene(name);
        Debug.Log(name+ " Loaded...");
    }

}
