using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public static int turn = 0;

    public void nextTurn()
    {
        turn += 1;
    }

}
