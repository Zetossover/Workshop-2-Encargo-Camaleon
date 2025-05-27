using UnityEngine;
using UnityEngine.SceneManagement;

public class Choque : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Camaleon"))
        {
            Debug.Log("Colisione");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
