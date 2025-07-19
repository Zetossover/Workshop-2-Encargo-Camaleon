using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBotonChange : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        BotonChangeScene();
    }
    void BotonChangeScene()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            SceneManager.LoadScene("Precipitacion");
        }
    }
}
