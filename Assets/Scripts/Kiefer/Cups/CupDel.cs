using UnityEngine;

public class CupDel : MonoBehaviour
{
    public void PullTrigger(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            collision.GetComponent<BallScript>().EndThisTurn();

            if (collision.GetComponent<BallScript>().BouncedAmount != 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
