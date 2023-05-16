using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] int BounceLimit = 3;
    [SerializeField] int BouncedAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(3, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = new Vector2(3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        BouncedAmount += 1;
        Debug.Log("Bounced: " + BouncedAmount);
        if (BouncedAmount > BounceLimit)
        {
            Debug.Log("Over Limit");
        }
    }
}
