using UnityEngine;

public class CatBed : MonoBehaviour
{
    private Mug mug;
    private GameObject cat;

    [SerializeField] private Animator blackScreenAnimator;

    // Start is called before the first frame update
    private void Start()
    {
        mug = FindObjectOfType<Mug>();
        cat = FindObjectOfType<PlayerMovement>().gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(mug.mugOnGround && collision.gameObject == cat)
        {
            blackScreenAnimator.SetTrigger("EndGame");
        }
    }
}
