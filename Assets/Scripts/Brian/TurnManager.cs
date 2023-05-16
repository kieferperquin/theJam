using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TurnManager")]
public class TurnManager : ScriptableObject
{
    public bool Playing;
    public int curPlayer;

    public void Reset()
    {
        Playing = false;
        curPlayer = 1;
    }
}
