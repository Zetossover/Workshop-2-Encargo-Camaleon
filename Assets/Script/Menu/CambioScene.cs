using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    public void ButtonChangeScene()
    {
        SceneManager.LoadScene("Evaporacion");
    }
}
