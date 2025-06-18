using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamaraDestroy : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D ray = Physics2D.Raycast(posMouse, Vector2.zero);
            if (ray.collider != null && ray.collider.TryGetComponent(out Precipitacion nube))
            {
                nube.OnClicked(posMouse);
            }
        }
    }
}
