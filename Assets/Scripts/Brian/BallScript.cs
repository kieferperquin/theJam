using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] int BounceLimit = 3;
    [SerializeField] int BouncedAmount = 0;
    [SerializeField] float startDirX = 3;
    [SerializeField] float startDirY = 3;
    bool limitReached = false;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(3, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = new Vector2(startDirX, startDirY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (limitReached)
        {
            Destroy(gameObject);
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
        Debug.Log("HitSide");
        Destroy(gameObject);
    }
}
