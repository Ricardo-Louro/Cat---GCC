using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private PlayerMovement playerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if((layerMask & (1 << other.gameObject.layer)) != 0)
        {
            playerMovement.grounded = true;
        }
        else
        {
            //It touched something that isn't the ground
        }
    }
}