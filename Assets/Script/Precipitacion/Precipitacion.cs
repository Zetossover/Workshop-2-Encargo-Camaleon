using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Precipitacion : MonoBehaviour
{
    [SerializeField] float tFinal;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Vector3 scaleInicial,scaleFinal;
    [SerializeField] Color colorInicial, colorFinal;
    [SerializeField] CamaraDestroy activable;
    

    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(CambioScale(scaleInicial, scaleFinal,tFinal));
        StartCoroutine(CambioColor(colorInicial, colorFinal, tFinal));
        StartCoroutine(CambioBool());
    }
    IEnumerator CambioBool()
    {
        yield return new WaitForSeconds(tFinal);
        activable.esActivable = true;
    }
    IEnumerator CambioColor(Color _colorInicial, Color _colorFinal, float duracion)
    {
        float tInicial = 0;
        while(tInicial <= duracion)
        {
            tInicial += Time.deltaTime;
            spriteRenderer.material.color = Color.Lerp(_colorInicial, _colorFinal, tInicial/duracion);
            yield return null;
        }
    }
    IEnumerator CambioScale(Vector3 _scaleInicial, Vector3 _scaleFinal, float duracion)
    {
        float tInicial = 0;
        
        while (tInicial <= duracion)
        {
            float x = Mathf.Lerp(_scaleInicial.x, _scaleFinal.x, tInicial / duracion);
            float y = Mathf.Lerp(_scaleInicial.y, _scaleFinal.y, tInicial / duracion);
            tInicial += Time.deltaTime;
            transform.localScale = new Vector3(x, y, 0);
            yield return null;
        }

        transform.localScale = _scaleFinal;
        
    }
}
