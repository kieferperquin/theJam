using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public ScoreData score;
    public TurnManager turn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CupGoal")
        {
            if (turn.curPlayer == 1)
            {
                score.RedScore++;
            }
            else if (turn.curPlayer == 2)
            {
                score.BlueScore++;
            }
        }
    }
}
