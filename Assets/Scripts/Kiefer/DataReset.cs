using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReset : MonoBehaviour
{
    public ScoreData score;
    public TurnManager turn;
    public UIManager UIManage;

    void Start()
    {
        score.ScoreReset();
        turn.Reset();
        UIManage.Reset();
    }
}
