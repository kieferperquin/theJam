using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public ScoreData score;
    public bool RedShot = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CupGoal")
        {
            if (RedShot)
            {
                score.RedScore++;
            }
        }
    }
}
