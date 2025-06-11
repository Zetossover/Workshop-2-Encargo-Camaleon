using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamaraDestroy : MonoBehaviour
{
    [SerializeField] GameObject gotitas,nubesPrefab;
    [SerializeField] Vector3 scaleInicial2D, scaleFinal2D;
    [SerializeField] float tFinal;
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
                    StartCoroutine(DisminuirScale(scaleFinal2D,scaleInicial2D, tFinal));
                    Instantiate(gotitas, posMouse, Quaternion.identity);
                    ray.collider.gameObject.SetActive(false);
                }
            }
        }
    }
    IEnumerator DisminuirScale(Vector3 _scaleInicial, Vector3 _scaleFinal, float duracion)
    {
        float tInicial = 0;

        while (tInicial <= duracion)
        {
            float x = Mathf.Lerp(_scaleInicial.x, _scaleFinal.x, tInicial / duracion);
            float y = Mathf.Lerp(_scaleInicial.y, _scaleFinal.y, tInicial / duracion);
            tInicial += Time.deltaTime;
            transform.localScale = new Vector3(x, y, 0);
            yield return null;
            break;
            
        }

        transform.localScale = _scaleFinal;

    }
}
