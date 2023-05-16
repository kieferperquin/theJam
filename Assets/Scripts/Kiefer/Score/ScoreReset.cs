using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{
    public ScoreData score;

    void Start()
    {
        score.ScoreReset();
    }
}
