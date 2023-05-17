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
        Reset();
        Time.timeScale = 1f;
    }

    public void Reset()
    {
        score.ScoreReset();
        turn.Reset();
        UIManage.Reset();
    }
}
