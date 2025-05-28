using UnityEngine;
using UnityEngine.SceneManagement;

public class CamaraDestroy : MonoBehaviour
{
    [SerializeField] GameObject gotitas;
    public bool esActivable = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D ray = Physics2D.Raycast(posMouse, Vector2.zero);
            if (ray.collider != null)
            {
                Debug.Log("choco" + ray.collider.name);
                if (ray.collider.CompareTag("Nube") && esActivable == true)
                {
                    ray.collider.gameObject.SetActive(false);
                    Instantiate(gotitas, posMouse, Quaternion.identity);
                }
            }
        }
    }
}
