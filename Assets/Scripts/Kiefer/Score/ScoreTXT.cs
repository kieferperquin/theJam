using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTXT : MonoBehaviour
{
    public ScoreData score;

    [SerializeField] Text RedScoreTXT;
    [SerializeField] Text BlueScoreTXT;

    private int oldRedScore;
    private int oldBlueScore;

    void Update()
    {
        if (oldBlueScore != score.BlueScore || oldRedScore != score.RedScore)
        {
            RedScoreTXT.text = $"score: {score.RedScore}";
            BlueScoreTXT.text = $"score: {score.BlueScore}";

            oldBlueScore = score.BlueScore;
            oldRedScore = score.RedScore;
        }
    }
}
