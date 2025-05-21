using UnityEngine;

public class DestruirNubes : MonoBehaviour
{
    bool EstaTocandoNube = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Collider2D collider2D = Physics2D.OverlapPoint(posMouse);
            RaycastHit2D ray = Physics2D.Raycast(posMouse, Vector2.one);
            if(ray.collider != null &&  ray.collider.CompareTag("Nube") && EstaTocandoNube)
            {
                Destroy(gameObject);
            }
            //if (collider2D != null && collider2D.CompareTag("Nube") && EstaTocandoNube)
            //{
            //    Destroy(gameObject);
            //}
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Nube"))
    //    {
    //        EstaTocandoNube = true;
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Nube"))
        {
            EstaTocandoNube = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Nube"))
        {
            EstaTocandoNube = false;
        }
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Nube"))
    //    {
    //        EstaTocandoNube = false;
    //    }
    //}
}
