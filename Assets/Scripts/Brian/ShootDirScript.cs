using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDirScript : MonoBehaviour
{
    Vector2 mousePosition;

    [SerializeField] GameObject Ball;
    [SerializeField] float ballSpeed = 3;
    GameObject spawnedBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - (Vector2)transform.position).normalized;
        transform.up = direction;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 BallDir = new Vector3(ballSpeed * direction.x, ballSpeed * direction.y); ;
            spawnedBall = Instantiate(Ball, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
            spawnedBall.GetComponent<BallScript>().startDir = BallDir;
        }
    }
}
