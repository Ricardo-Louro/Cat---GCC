using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 rotation;
    private Rigidbody rb;

    private float moveX;
    private float moveY;

    private Vector3 moveDirection;

    private bool jumping = false;
    public bool grounded = false;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpSpeed;
    
    // Start is called before the first frame update
    private void Start()
    {
        rotation = Vector3.zero;
        rb = GetComponent<Rigidbody>();
        moveDirection = Vector3.zero;
    }

    // Update is called once per frame
    private void Update()
    {
        ReceiveInput();
        SetMoveDirection();

        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            grounded = false;
            jumping = true;
        }
    }

    private void FixedUpdate()
    {
        SetVelocity();
    }

    private void ReceiveInput()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
    }

    private void SetMoveDirection()
    {
        moveDirection = transform.forward * moveY + transform.right * moveX;
    }

    private void SetVelocity()
    {
        Vector3 vel = moveDirection * (moveSpeed * Time.fixedDeltaTime);
        vel.y = rb.velocity.y;

        if(jumping == true)
        {
            jumping = false;
            vel.y += jumpSpeed * Time.fixedDeltaTime; 
        }
        if(!grounded)
        {
            vel.y += Physics.gravity.y * Time.fixedDeltaTime;
            vel.y = Mathf.Max(vel.y, Physics.gravity.y);
        }

        rb.velocity = vel;
    }   

    public void SetRotation(float value)
    {
        rotation.y = value;
        transform.eulerAngles = rotation;
    }
}