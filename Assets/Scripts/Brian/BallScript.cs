using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] TurnManager turn;

    [SerializeField] int BounceLimit = 3;
    public int BouncedAmount = 0;
    public Vector2 startDir = new Vector2(3, 3);
    bool limitReached = false;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(3, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = startDir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (limitReached)
        {
            EndThisTurn();
        }    

        BouncedAmount += 1;
        Debug.Log("Bounced: " + BouncedAmount);
        if (BouncedAmount >= BounceLimit)
        {
            Debug.Log("Over Limit");
            limitReached = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "CupGoal")
        {
            Debug.Log("HitSide");
            EndThisTurn();
        }
    }

    public void EndThisTurn()
    {
        Debug.Log("EndThisTurn");
        turn.EndTurn();
        Destroy(gameObject);
    }    
}
