using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
