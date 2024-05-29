using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform cameraPosition;
    private PlayerMovement playerMovement;

    private float rotX = 0;
    private float rotY = 0;

    [SerializeField] private float mouseSensitivityX;
    [SerializeField] private float mouseSensitivityY;

    private Vector3 rotation;


    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        playerMovement = FindObjectOfType<PlayerMovement>();
        rotation = Vector3.zero;
    }

    // Update is called once per frame
    private void Update()
    {
        ReceiveInputs();
        SetRotation();
        ApplyRotation();

        UpdatePosition();
        playerMovement.SetRotation(rotX);
    }

    private void ReceiveInputs()
    {
        rotX += Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        rotY -= Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        rotY = Mathf.Clamp(rotY, -50, 30);
    }

    private void SetRotation()
    {
        rotation.x = rotY;
        rotation.y = rotX;
    }

    private void ApplyRotation()
    {
        transform.eulerAngles = rotation;
    }

    private void UpdatePosition()
    {
        transform.position = cameraPosition.position;
    }
}
