using UnityEngine;

public class Arrastrar_Agua : MonoBehaviour
{
    [SerializeField] GameObject objetoArrastrado;
    private float distanciaObjeto;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.CompareTag("Agua"))
                {
                    objetoArrastrado = hit.collider.gameObject;
                    distanciaObjeto = Vector3.Distance(Camera.main.transform.position, objetoArrastrado.transform.position);
                    Debug.Log("Objeto con tag 'Agua' detectado: " + objetoArrastrado.name);
                }
            }
        }

        if (Input.GetMouseButton(0) && objetoArrastrado != null)
        {
            Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            objetoArrastrado.transform.position = new Vector3(posicionMouse.x, posicionMouse.y, objetoArrastrado.transform.position.z);
        }

        if (Input.GetMouseButtonUp(0))
        {
            objetoArrastrado = null;
        }
    }
}
