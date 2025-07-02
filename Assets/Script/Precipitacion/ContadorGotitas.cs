using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContadorGotitas : MonoBehaviour
{
    [SerializeField] int gotitasMaximas = 40, contadorGotitas;
    [SerializeField] Image barraDeAgua;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contadorGotitas = 0;
        barraDeAgua.fillAmount = 0f;
    }
    void Update()
    {
        NextScene();
    }
    void NextScene()
    {
        if(contadorGotitas >= gotitasMaximas)
        {
            SceneManager.LoadScene("Final");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Gotitas"))
        {
            contadorGotitas++;
            barraDeAgua.fillAmount = (float)contadorGotitas / gotitasMaximas;
            Destroy(collision.gameObject);
        }
    }
}
