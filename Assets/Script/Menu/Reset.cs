using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void Update()
    {
        ResetBoton();
    }
    void ResetBoton()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void ButtonResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
