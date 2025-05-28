using UnityEngine;
using UnityEngine.SceneManagement;

public class DestruirNubes : MonoBehaviour
{
    bool EstaTocandoNube = false;
    public int contadorNubes;

    void Start()
    {
        contadorNubes = 16;
        
    }
    void NextScene()
    {
        if(contadorNubes <= 0)
        {
            SceneManager.LoadScene("Condensacion");
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D ray = Physics2D.Raycast(posMouse, Vector2.zero);
            if(ray.collider != null)            
            {    
                Debug.Log("choco" + ray.collider.name);
                if (ray.collider.CompareTag("Nube"))
                {
                    ray.collider.gameObject.SetActive(false);
                    contadorNubes -= 1;
                }
            }
        }
        if(contadorNubes <= 0)
        {
            Debug.Log("Cambio");
            NextScene();
        }
    }
}
