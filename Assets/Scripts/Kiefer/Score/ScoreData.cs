using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "scoreData")]
public class ScoreData : ScriptableObject
{
    public int RedScore;
    public int RedFailCounter;

    public int BlueScore;
    public int BlueFailCounter;

    public void ScoreReset()
    {
        RedScore = 0;
        RedFailCounter = 0;

        BlueScore = 0;
        BlueFailCounter = 0;
    }
}
