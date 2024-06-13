using UnityEngine;

public class CatBed : MonoBehaviour
{
    [SerializeField] private Animator blackScreenAnimator;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>() != null)
        {
            blackScreenAnimator.SetTrigger("EndGame");
        }
    }
}