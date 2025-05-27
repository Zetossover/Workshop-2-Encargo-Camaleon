using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorGotitas : MonoBehaviour
{
    public int contadorGotitas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contadorGotitas = 0;
    }
    void Update()
    {
        NextScene();
    }
    void NextScene()
    {
        if(contadorGotitas >= 10)
        {
            SceneManager.LoadScene("Final");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Gotitas"))
        {
            contadorGotitas++;
        }
    }
}
