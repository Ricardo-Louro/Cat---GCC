using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGameOnActivate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        SceneManager.LoadScene(0);
    }
}
