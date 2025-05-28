using UnityEngine;
using UnityEngine.SceneManagement;

public class Condensacion : MonoBehaviour
{
    //velocidad hacia arriba y velocidad cuando se aleja del cursor
    [SerializeField] float velocidadUp, velocidadLateral;
    [SerializeField] float radioMos;
    [SerializeField] Camera cameraPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraPos = Camera.main;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Meta"))
        {
            SceneManager.LoadScene("Precipitacion");
        }
    }
    void MoveUp()
    {
        //movimiento hacia arriba
        transform.Translate(Vector2.up * velocidadUp * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        MoveUp();
        //se encarga de la posicion del mouse
        Vector3 posMouse = cameraPos.ScreenToWorldPoint(Input.mousePosition);
        posMouse.z = 0f;
        //distancia entre el objeto
        float distancia = Vector2.Distance(transform.position, posMouse);
        if(distancia < radioMos)
        {
            //saber en que lado esta
            float disPosMouse = posMouse.x - transform.position.x;
            //Si el cursor está a la derecha, el objeto se mueve a la izquierda, y viceversa
            float mouseOposDirection = disPosMouse > 0 ? -1 : 1;
            //aplicar movimiento lateral
            transform.Translate(Vector2.right * mouseOposDirection * velocidadLateral * Time.deltaTime);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radioMos);
    }
}
