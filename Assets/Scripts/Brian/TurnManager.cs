using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TurnManager")]
public class TurnManager : ScriptableObject
{
    public bool playing;
    public int curPlayer;

    public void Reset()
    {
        playing = false;
        curPlayer = 1;
    }
    public void EndTurn()
    {
        if (curPlayer == 1)
        {
            curPlayer = 2;
        }
        else
        {
            curPlayer = 1;
        }
        playing = false;
    }
}
