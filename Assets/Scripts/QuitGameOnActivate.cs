using UnityEngine;

public class QuitGameOnActivate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Application.Quit();
    }
}
