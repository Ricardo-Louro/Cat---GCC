using UnityEngine;

public class Mug : MonoBehaviour
{
    public bool mugOnGround;

    [SerializeField] private GameObject floor;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == floor && !mugOnGround)
        {
            mugOnGround = true;
            audioSource.Play();
        }
    }
}
