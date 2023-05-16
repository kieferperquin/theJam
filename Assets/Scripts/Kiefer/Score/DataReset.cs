using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{
    public ScoreData score;
    public TurnManager turn;

    void Start()
    {
        score.ScoreReset();
        turn.Reset();
    }
}
