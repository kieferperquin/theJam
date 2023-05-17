using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    public GameObject FollowLocation;
    public bool enableRay = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enableRay == true)
        {
            gameObject.transform.position = FollowLocation.transform.position;
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            //Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(3, 3), 1000);
            Debug.DrawLine(transform.position, hit.point) ;

            //If something was hit, the RaycastHit2D.collider will not be null.
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}
