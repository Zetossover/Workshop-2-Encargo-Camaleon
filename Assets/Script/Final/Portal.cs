using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Transform puntoFinal;
    [SerializeField] float tiempo = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tuberias"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Invoke("LlegarAlFinal", tiempo);
        }
    }
    void LlegarAlFinal()
    {
        transform.position = puntoFinal.position;
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
    }
}
