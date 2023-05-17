using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UIManager")]
public class UIManager : ScriptableObject
{
    public bool pausedGame;
    //ANY settings

    public void Reset()
    {
        pausedGame = false;
    }
}
