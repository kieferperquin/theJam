using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCon : MonoBehaviour
{
    public ScoreData score;
    public int MaxScore;
    private bool RedWon;
    private bool BlueWon;

    void Update()
    {
        if (score.RedScore == MaxScore && BlueWon == false)
        {
            RedWon = true;
            Debug.Log("Red wins");
            SendWinner(1);
        }
        else if (score.BlueScore == MaxScore && RedWon == false)
        {
            BlueWon = true;
            Debug.Log("Blue wins");
            SendWinner(2);
        }
    }

    void SendWinner(int PlayerWon)
    {
        //get a script that puts up a screen for the winner based on what number (1 or 2)
        //and put a line here that send that number (1 or 2) to that script
    }
}
