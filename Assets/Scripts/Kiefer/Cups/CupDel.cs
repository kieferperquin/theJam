using UnityEngine;

public class CupDel : MonoBehaviour
{
    public void PullTrigger(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            collision.GetComponent<BallScript>().EndThisTurn();
        }
        Destroy(gameObject);
    }
}