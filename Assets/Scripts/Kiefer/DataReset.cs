using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReset : MonoBehaviour
{
    public ScoreData score;
    public TurnManager turn;

    void Start()
    {
        score.ScoreReset();
        turn.Reset();
    }
}
