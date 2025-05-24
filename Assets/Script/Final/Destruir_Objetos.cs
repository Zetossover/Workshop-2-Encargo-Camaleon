using System.Collections;
using UnityEngine;

public class Destruir_Objetos : MonoBehaviour
{


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
                if (ray.collider.CompareTag("Objetos"))
                {
                    ray.collider.gameObject.SetActive(false);
                    
                }
            }
        }
    }
    
    
}
