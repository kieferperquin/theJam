using UnityEngine;

public class CupGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        gameObject.GetComponentInParent<CupDel>().PullTrigger(collision);
    }
}
