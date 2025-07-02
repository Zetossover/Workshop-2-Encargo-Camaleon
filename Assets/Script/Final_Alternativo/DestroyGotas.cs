using UnityEngine;

public class DestroyGotas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            Destroy(gameObject);
        }
    }
}
