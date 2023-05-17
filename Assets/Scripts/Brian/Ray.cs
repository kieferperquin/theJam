using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    public GameObject FollowLocation;
    public bool enableRay = false;
    public Color rayColor = Color.white;
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
            gameObject.transform.rotation = FollowLocation.transform.rotation;
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            //Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
            Debug.DrawLine(transform.position, hit.point, rayColor) ;

            //If something was hit, the RaycastHit2D.collider will not be null.
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);

                Vector2 inDirection = Vector2.Reflect(transform.up, hit.normal);

                Debug.DrawRay(hit.point, inDirection * 100, rayColor);
                hit = Physics2D.Raycast(hit.point + hit.normal * 0.01f, inDirection);
                if (hit != null && hit.collider != null)
                {
                    inDirection = Vector3.Reflect(inDirection, hit.normal);
                    Debug.DrawRay(hit.point, inDirection * 100, rayColor);
                }

            }
        }
    }
}
