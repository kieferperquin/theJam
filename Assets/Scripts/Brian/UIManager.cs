using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UIManager")]
public class UIManager : ScriptableObject
{
    public bool pausedGame;
    public bool finished;
    public bool start;
    //ANY settings

    public void Reset()
    {
        pausedGame = false;
        finished = false;
        start = true;
    }
}
