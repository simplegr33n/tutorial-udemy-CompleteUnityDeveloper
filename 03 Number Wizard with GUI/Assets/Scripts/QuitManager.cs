using UnityEngine;

public class QuitManager : MonoBehaviour {

    public void QuitManage()
    {
        Debug.Log(name + " Loaded...");
        Application.Quit();
    }

}
