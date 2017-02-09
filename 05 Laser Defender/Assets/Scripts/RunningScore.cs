using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunningScore : MonoBehaviour {

    public static Text score;

    public static int scoreFinal;

	// Use this for initialization
	void Start () {

        score = GetComponent<Text>();
        score.text = "" + scoreFinal;

    }



	public static void Score () {
        scoreFinal = EnemyShip.killCount * 150;

        score.text = "" + scoreFinal;
	}

    public static void Reset()
    {
        scoreFinal = 0;
        EnemyShip.killCount = 0;
        EnemyShip.shipsCount = 0;
    }
}
