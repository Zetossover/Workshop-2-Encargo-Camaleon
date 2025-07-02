using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choque : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI aguaTxt;
    [SerializeField] int count,currentCount;

    void Start()
    {
        count = 10; 
        aguaTxt.text = currentCount + " / " + count;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Agua"))
        {
            Debug.Log("Colisione");
            currentCount++;
            aguaTxt.text = currentCount + " / " + count;
            Destroy(collision.gameObject);
            
        }
        if(currentCount >= count)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
