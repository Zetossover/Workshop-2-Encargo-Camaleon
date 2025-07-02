using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioSceneFinal_Alternativo : MonoBehaviour
{
    [SerializeField] int contador, contadorMax = 139;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SceneChangeFinal();
    }
    void SceneChangeFinal()
    {
        if(contador >= contadorMax)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    private void OnTriggerEnter2D(Collider2D cother)
    {
        if (cother.CompareTag("Gotitas"))
        {
            contador++;
            Destroy(cother.gameObject);
        }
    }
}
